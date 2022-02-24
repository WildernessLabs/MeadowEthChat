using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Threading.Tasks;


namespace MeadowChat
{
    class ChatRecv
    {
        private int numbRecv = 0;
        private MeadowEthChatUi meadowChatUi;
        private ChatManager chatManager;
        TcpClient tcpClient;

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
            byte[] recvBuffer = new byte[2048];
            try
            {
                meadowChatUi.WriteStatusSafe($"Beginning receive");
                while (true)
                {
                    int bytesRead = await netStream.ReadAsync(recvBuffer, 0,
                        recvBuffer.Length).ConfigureAwait(false);
                    if (bytesRead == 0)
                    {
                        meadowChatUi.WriteStatusSafe($"Server has disconnected");
                        Thread.Sleep(500);
                    }
                    else
                    {
                        //meadowChatUi.WriteStatusSafe($"Received {bytesRead} bytes");
                        string recvString = Encoding.UTF8.GetString(recvBuffer, 0, bytesRead);
                        meadowChatUi.WriteReceiveSafe(recvString);
                        numbRecv++;
                        meadowChatUi.WriteReceiveCountSafe(numbRecv.ToString());

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
    }
}
