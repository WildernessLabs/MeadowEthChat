using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace MeadowChat
{
    class ChatManager
    {
        ChatRecv _chatRecv;
        ChatSend _chatSend;
        CircularBuffer _chatCirBuf;
        readonly int chatPort;
        readonly IPAddress chatIpAddress;
        MeadowEthChatUi meadowChatUi;

        internal AutoResetEvent sendMoreDataEvent = new AutoResetEvent(false);

        public TcpClient? TcpClient { get; set; }
        internal ChatRecv ChatRecv { get => _chatRecv; set => _chatRecv = value; }
        internal ChatSend ChatSend { get => _chatSend; set => _chatSend = value; }
        internal CircularBuffer ChatCirBuf { get => _chatCirBuf; set => _chatCirBuf = value; }
        public NetworkStream? ChatStream { get; set; }

        // Ctor
        public ChatManager(MeadowEthChatUi meadowChatUi)
        {
            this.meadowChatUi = meadowChatUi;

            chatPort = int.Parse(this.meadowChatUi.ReadMessagePort());
            chatIpAddress = IPAddress.Parse(this.meadowChatUi.ReadMeadowIp());

            TcpClient = new TcpClient(AddressFamily.InterNetwork);
            _chatRecv = new ChatRecv(this, this.meadowChatUi);
            _chatSend = new ChatSend(this, this.meadowChatUi);
            _chatCirBuf = new CircularBuffer();
        }

        // Called when connect button clicked
        public async void StartChat()
        {
            // Initialize receive buffer
            _chatCirBuf.Init(65536);

            while (true)
            {
                try
                {
                    if(TcpClient == null)
                    {
                        throw new Exception("TcpClient is null");
                    }

                    if (!TcpClient.Connected)
                    {
                        await TcpClient.ConnectAsync(chatIpAddress, chatPort).ConfigureAwait(false);

                        // Get and save the stream
                        ChatStream = TcpClient.GetStream();
                        meadowChatUi.WriteStatusSafe($"Connection made to server");
                    }
                    else
                    {
                        Thread.Sleep(0);    // place for break point
                        throw new Exception("Not connected");
                    }

                    // Start receiving forever
                    await Task.Run(() => ChatRecv.ReceiveChatData(ChatStream)).ConfigureAwait(false);
                }
                catch (SocketException sockex)
                {
                    if (sockex.SocketErrorCode == SocketError.IsConnected)
                    {
                        meadowChatUi.WriteStatusSafe($"SocketException:IsConnected {Environment.NewLine}");
                        meadowChatUi.WriteStatusSafe($"SocketException:{sockex} {Environment.NewLine}");
                        if(TcpClient != null)
                        {
                            TcpClient.Close();
                            TcpClient = null;
                        }
                    }
                    else if (sockex.SocketErrorCode == SocketError.ConnectionRefused)
                    {
                        meadowChatUi.WriteStatusSafe($"SocketException:Connection refused {Environment.NewLine}");
                        meadowChatUi.WriteStatusSafe($"SocketException:{sockex} {Environment.NewLine}");
                        // no one's listening
                    }
                    else
                    {
                        meadowChatUi.WriteStatusSafe($"SocketException:{sockex} {Environment.NewLine}");
                    }
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    meadowChatUi.WriteStatusSafe($"Exception:'{ex}'");
                    Thread.Sleep(1000);
                }
            }   // while(true)

            //meadowChat.WriteStatusSafe($"Connection dropped receive loop");
        }
    }
}
