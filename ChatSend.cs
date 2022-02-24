using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MeadowChat
{
    class ChatSend
    {
        private int numbSent = 0;
        private ChatManager chatManager;
        private MeadowEthChatUi meadowChatUi;

        public ChatSend(ChatManager chatManager, MeadowEthChatUi meadowChatUi)
        {
            this.chatManager = chatManager;
            this.meadowChatUi = meadowChatUi;
        }

        public async Task SendMsgData(byte[] dataToSend, int dataLength)
        {
            try
            {
                if (dataToSend == null || dataLength == 0)
                    return;

                if (chatManager.ChatStream.CanWrite)
                {
                    meadowChatUi.WriteStatusSafe($"Sending {dataLength} bytes");
                    await chatManager.ChatStream.WriteAsync(dataToSend, 0, dataLength).ConfigureAwait(false);

                    numbSent++;
                    meadowChatUi.WriteSendCountSafe(numbSent.ToString());
                    //meadowChatUi.ClearToSendSafe("");
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

    }
}
