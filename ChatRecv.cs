using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;

namespace MeadowChat
{
    class ChatRecv
    {
        private MeadowEthChatUi meadowChatUi;
        private ChatManager chatManager;
        TcpClient tcpClient;
        int _totalRecvMsg = 0;
        int _totalMismatch = 0;
        int _totalMatch = 0;

        // Ctor
        //===========================================================
        public ChatRecv(ChatManager chatManager, MeadowEthChatUi meadowChatUi)
        {
            this.chatManager = chatManager;
            this.meadowChatUi = meadowChatUi;

            tcpClient = chatManager.TcpClient;
        }

        //===========================================================
        public async Task ReceiveChatData(NetworkStream netStream)
        {
            byte[] recvBuffer = new byte[4096];

            bool keepRunning = true;

            try
            {
                meadowChatUi.WriteStatusSafe($"Beginning receive");
                while (keepRunning)
                {
                    //Debug.WriteLine($"Reading data from Ethernet");
                    int bytesRead = await netStream.ReadAsync(recvBuffer, 0, recvBuffer.Length).ConfigureAwait(false);
                    if (bytesRead > 0)
                    {
                        // Add the received bytes to the buffer and verify it
                        //Debug.WriteLine($"Read {bytesRead} bytes, calling Add and process data.");
                        AddAndProcessData(recvBuffer, bytesRead);
                    }
                    else if(bytesRead == 0)
                    {
                        Debug.WriteLine($"Read {bytesRead} bytes, Server has disconnected");
                        meadowChatUi.WriteStatusSafe($"Server has disconnected");
                        Debug.Assert(false);
                    }
                    else
                    {
                        Debug.WriteLine($"Read {bytesRead} bytes, Unknown / Enexpected error");
                        meadowChatUi.WriteStatusSafe($"ReadAsync returned unexpected value:{bytesRead}");
                        Debug.Assert(false);
                    }
                }
            }
            catch (System.IO.IOException ioe)
            {
                meadowChatUi.WriteStatusSafe($"IO.Exception: {ioe}");
            }
            catch (Exception ex)
            {
                meadowChatUi.WriteStatusSafe($"Exception: {ex}");
            }
        }

        //==================================================================
        void AddAndProcessData(byte[] buffer, int availableBytes)
        {
            HcomBufferReturn result;
            while (true)
            {
                // Add these bytes to the circular buffer
                Console.WriteLine($"==> {DateTime.Now:HH:mm:ss.fff}-**Calling AddBytes to add {availableBytes} bytes to Circular buffer");
                result = chatManager.ChatCirBuf.AddBytes(buffer, 0, availableBytes);
                if (result == HcomBufferReturn.CIR_BUF_ADD_SUCCESS)
                {
                    break;
                }
                else if (result == HcomBufferReturn.CIR_BUF_ADD_WONT_FIT)
                {
                    // Wasn't possible to put these bytes in the buffer. We need to
                    // process a few packets and then retry to add this data
                    result = PullAndVerifyAPacket();
                    if (result == HcomBufferReturn.CIR_BUF_GET_FOUND_MSG ||
                        result == HcomBufferReturn.CIR_BUF_GET_NONE_FOUND)
                        continue;   // There should be room now for the failed add

                    if (result == HcomBufferReturn.CIR_BUF_GET_BUF_NO_ROOM)
                    {
                        // The buffer to receive the message is too small? Probably 
                        // corrupted data in buffer.
                        Debug.Assert(false);
                    }
                }
                else if (result == HcomBufferReturn.CIR_BUF_ADD_BAD_ARG)
                {
                    // Something wrong with implemenation
                    Debug.Assert(false);
                }
                else
                {
                    // Undefined return value????
                    Debug.Assert(false);
                }
            }

            result = PullAndVerifyAPacket();

            // Any other response is an error
            Debug.Assert(result == HcomBufferReturn.CIR_BUF_GET_FOUND_MSG ||
                result == HcomBufferReturn.CIR_BUF_GET_NONE_FOUND);
        }

        //===========================================================
        HcomBufferReturn PullAndVerifyAPacket()
        {
            byte[] packetBuffer = new byte[4096];

            int packetLength;
            HcomBufferReturn result;

            // This includes to 0x00 terminator
            result = chatManager.ChatCirBuf.GetNextPacket(packetBuffer, 2048, out packetLength);
            if (result == HcomBufferReturn.CIR_BUF_GET_FOUND_MSG)
            {
                packetLength--;         // Effectively remove the 0x00 terminator

                // Compare length but received will have 1 more byte, the terminator
                if (meadowChatUi.sentDataBuffer.Length != packetLength)
                {
                    _totalMismatch++;
                    meadowChatUi.WriteMismatchCountSafe(_totalMismatch.ToString());
                    Debug.WriteLine($"Length not equal, found {packetLength} bytes, sent {meadowChatUi.sentDataBuffer.Length} bytes");
                    meadowChatUi.WriteReceiveSafe($"Length not equal, received {packetLength} bytes, sent {meadowChatUi.sentDataBuffer.Length} bytes");
                }
                else
                {
                    int byteOff;

                    // Check if send data same as received
                    for(byteOff = 0; byteOff < packetLength; byteOff++)
                    {
                        if (meadowChatUi.sentDataBuffer[byteOff] != packetBuffer[byteOff])
                        {
                            break;
                        }
                    }

                    // Did we check all the bytes? If so must have matched
                    if(byteOff == packetLength)
                    {
                        _totalMatch++;
                        meadowChatUi.WriteMatchCountSafe(_totalMatch.ToString());
                        //meadowChatUi.WriteReceiveSafe($"Recv'd matched sent {_totalMatch} times");
                    }
                    else
                    {
                        _totalMismatch++;
                        meadowChatUi.WriteMismatchCountSafe(_totalMismatch.ToString());
                        meadowChatUi.WriteReceiveSafe($"Recv'd mismatch sent {_totalMismatch} times");
                    }
                }

                _totalRecvMsg++;
                meadowChatUi.WriteReceiveCountSafe(_totalRecvMsg.ToString());

                // Allow another packet to be sent
                chatManager.sendMoreDataEvent.Set();
            }
            else if (result == HcomBufferReturn.CIR_BUF_GET_NONE_FOUND)
            {
                return result;      // We've emptied buffer of all messages
            }
            else if (result == HcomBufferReturn.CIR_BUF_GET_BUF_NO_ROOM)
            {
                // The buffer to receive the message is too small! Perhaps 
                // corrupted data in buffer.
                Debug.Assert(false);
            }
            else
            {
                string msg = string.Format($"Orphan Data: 0x{packetBuffer[packetLength - 1]:x2}");
                meadowChatUi.WriteReceiveSafe(msg);
            }

            return result;
        }

        //==================================================================
        // Send button pressed. Clear existing information.
        internal void ClearPreSend()
        {
            _totalRecvMsg = 0;
            _totalMismatch = 0;
            _totalMatch = 0;

            meadowChatUi.WriteMatchCountSafe(_totalMatch.ToString());
            meadowChatUi.WriteMismatchCountSafe(_totalMismatch.ToString());
        }
    }
}
