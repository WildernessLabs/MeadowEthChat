using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeadowChat
{
    public partial class MeadowEthChatUi : Form
    {
        private delegate void SafeCallDelegate(string text);

        ChatManager chatManager;
        internal bool useRandomMsg;
        internal byte[]? sentDataBuffer;     // shared by xmit and recv

        public MeadowEthChatUi()
        {
            InitializeComponent();

            chatManager = new ChatManager(this);
            useRandomMsg = false;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            int sendCount = int.Parse(ReadSendCount());
            chatManager.ChatSend.ClearPreSend();
            chatManager.ChatRecv.ClearPreSend();
            chatManager.ChatSend.PrepareAndSend(sendCount, sendTextBox.Text);
        }

        //=====================================================
        private void connectButton_Click(object sender, EventArgs e)
        {
            chatManager.StartChat();
        }

        //=====================================================
        // Read the Meadow ip address
        internal string ReadMeadowIp()
        {
            return this.meadowIpTextbox.Text;
        }

        //=====================================================
        // Read the Message To Send
        internal string ReadMessagePort()
        {
            return this.ipPortTextBox.Text;
        }

        //=====================================================
        // Read the number of times to send the message
        internal string ReadSendCount()
        {
            return this.sendCountTextbox.Text;
        }

        //=====================================================
        // Read the Message To Send
        internal string ReadMessageToSend()
        {
            return this.sendTextBox.Text;
        }

        //=====================================================
        // Safely clean the sent data textbox
        internal void ClearToSendSafe(string text)
        {
            if (sendTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(ClearToSendSafe);
                sendTextBox.Invoke(d, new object[] { text });
            }
            else
            {
                sendTextBox.Text = String.Empty;
            }
        }

        //=====================================================
        // Safely write received data to textbox
        internal void WriteReceiveCountSafe(string text)
        {
            if (recvCntTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteReceiveCountSafe);
                recvCntTextBox.Invoke(d, new object[] { text });
            }
            else
            {
                recvCntTextBox.Text = text;
            }
        }

        //=====================================================
        // Safely write sent count data to textbox
        internal void WriteSendCountSafe(string text)
        {
            if (sendCntTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteSendCountSafe);
                sendCntTextBox.Invoke(d, new object[] { text });
            }
            else
            {
                sendCntTextBox.Text = text;
            }
        }

        //=====================================================
        // Safely write verification matches count data to textbox
        internal void WriteMatchCountSafe(string text)
        {
            if (matchCntTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteMatchCountSafe);
                matchCntTextBox.Invoke(d, new object[] { text });
            }
            else
            {
                matchCntTextBox.Text = text;
            }
        }

        //=====================================================
        // Safely write verification mismatches count data to textbox
        internal void WriteMismatchCountSafe(string text)
        {
            if (mismatchCntTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteMismatchCountSafe);
                mismatchCntTextBox.Invoke(d, new object[] { text });
            }
            else
            {
                mismatchCntTextBox.Text = text;
            }
        }

        //=====================================================
        // Safely write verification mismatches count data to textbox
        internal void WriteTotalExecTimeSafe(string text)
        {
            if (totalExecTimeTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTotalExecTimeSafe);
                totalExecTimeTextBox.Invoke(d, new object[] { text });
            }
            else
            {
                totalExecTimeTextBox.Text = text;
            }
        }

        //=====================================================
        // Safely write received data to textbox
        internal void WriteReceiveSafe(string text)
        {
            if (recvTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteReceiveSafe);
                recvTextBox.Invoke(d, new object[] { text });
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{DateTime.Now:HH:mm:ss.fff}-{text}");
                recvTextBox.AppendText(sb.ToString());
            }
        }

        //=====================================================
        // Safely write status data to textbox
        internal void WriteStatusSafe(string text)
        {
            if (statusTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteStatusSafe);
                statusTextBox.Invoke(d, new object[] { text });
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{DateTime.Now:HH:mm:ss.fff}-{text}");
                statusTextBox.AppendText(sb.ToString());
            }
        }

        //=====================================================
        // Generate Random Message, both length and data.
        private void genRandomMsgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (genRandomMsgCheckBox.Checked)
            {
                useRandomMsg = true;
            }
            else
            {
                useRandomMsg = false;
            }
        }
    }
}
