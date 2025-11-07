using MeadowChat;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MeadowChat
{
    class ChatSend
    {
        private int numbSent = 0;
        private ChatManager chatManager;
        private MeadowEthChatUi meadowChatUi;
        int _sendCount;
        string? _textToSend;
        Random rand;
        Thread? _sendThread;
        private Stopwatch _stopwatch = new Stopwatch();

        public ChatSend(ChatManager chatManager, MeadowEthChatUi meadowChatUi)
        {
            this.chatManager = chatManager;
            this.meadowChatUi = meadowChatUi;

            rand = new Random();
        }

        // So the UI thread can return to doing UI work a thread is
        // created here to send the message(s)
        internal void PrepareAndSend(int sendCount, string textToSend)
        {
            _sendCount = sendCount;

            if(textToSend != null)
            {
                _textToSend = textToSend;

                _sendThread = new Thread(new ThreadStart(ThreadToSend));
                _sendThread.Start();
            }
            else
            {
                meadowChatUi.WriteStatusSafe($"No text provided");
            }
        }
        
        // This thread sends the data 
        internal void ThreadToSend()
        {
            byte[] completeMsg;

            _stopwatch.Restart();
            for (int sendId = 0; sendId < _sendCount; sendId++)
            {
                if (meadowChatUi.useRandomMsg)
                {
                    // Create random length buffer with random data
                    int randLength = rand.Next(1, 2048);
                    meadowChatUi.sentDataBuffer = new byte[randLength];
                    rand.NextBytes(meadowChatUi.sentDataBuffer);

                    // Must prevent '0' from being in the buffer
                    for (int zeroOffChk = 0; zeroOffChk < randLength; zeroOffChk++)
                    {
                        if (meadowChatUi.sentDataBuffer[zeroOffChk] == 0)
                            meadowChatUi.sentDataBuffer[zeroOffChk] = (byte)rand.Next(1, 255);
                    }
                }
                else
                {
                    if(_textToSend == null)
                    {
                        throw new Exception("_textToSend is null");
                    }
                    meadowChatUi.sentDataBuffer = Encoding.UTF8.GetBytes(_textToSend);
                }

                // Create a buffer for the complete message accounting for terminating byte
                completeMsg = new byte[meadowChatUi.sentDataBuffer.Length + 1];

                // Copy the message to the head of the buffer
                Array.Copy(meadowChatUi.sentDataBuffer, 0, completeMsg, 0, meadowChatUi.sentDataBuffer.Length);

                // Separate each packet with a '0' because the receiver often combines
                // messages in it's receive buffer.
                completeMsg[meadowChatUi.sentDataBuffer.Length] = 0;

                Debug.WriteLine($"Sending message {sendId + 1}");
                _ = SendMsgData(completeMsg, completeMsg.Length);

                if((sendId % 100) == 0)
                {
                    meadowChatUi.WriteTotalExecTimeSafe($"{_stopwatch.Elapsed:hh\\:mm\\:ss\\.fff}");
                }

                // Wait until receive has finished verifying the last message sent
                //Debug.WriteLine($"Waiting to be notified it's okay to send next message.");
                chatManager.sendMoreDataEvent.WaitOne();
            }

            _stopwatch.Stop();
            meadowChatUi.WriteTotalExecTimeSafe($"{_stopwatch.Elapsed:hh\\:mm\\:ss\\.fff}");
        }

        public async Task SendMsgData(byte[] dataToSend, int dataLength)
        {
            try
            {
                if (dataToSend == null || dataLength == 0)
                    return;

                if (chatManager.ChatStream == null)
                    return;
                
                if (chatManager.ChatStream.CanWrite)
                {
                    numbSent++;
                    if (meadowChatUi.useRandomMsg)
                        meadowChatUi.WriteStatusSafe($"{numbSent} - Sending {dataLength} random bytes");
                    else
                        meadowChatUi.WriteStatusSafe($"{numbSent} - Sending {dataLength} bytes of text");

                    // Send data
                    await chatManager.ChatStream.WriteAsync(dataToSend, 0, dataLength).ConfigureAwait(false);

                    meadowChatUi.WriteSendCountSafe(numbSent.ToString());
                }
                else
                {
                    meadowChatUi.WriteStatusSafe("****** ChatStream CANNOT WRITE ******");
                }
            }
            catch (Exception ex)
            {
                meadowChatUi.WriteStatusSafe($"Exception: {ex}");
            }
        }

        //==================================================================
        // Send button pressed. Clear existing information.
        internal void ClearPreSend()
        {
            numbSent = 0;
        }
    }
}
