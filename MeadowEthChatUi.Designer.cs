
namespace MeadowChat
{
    partial class MeadowEthChatUi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            meadowIpTextbox = new TextBox();
            sendTextBox = new TextBox();
            recvTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            sendButton = new Button();
            sendCntTextBox = new TextBox();
            recvCntTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            connectButton = new Button();
            ipPortTextBox = new TextBox();
            label6 = new Label();
            statusTextBox = new TextBox();
            label7 = new Label();
            sendCountTextbox = new TextBox();
            label9 = new Label();
            genRandomMsgCheckBox = new CheckBox();
            matchCntTextBox = new TextBox();
            mismatchCntTextBox = new TextBox();
            label8 = new Label();
            label10 = new Label();
            totalExecTimeTextBox = new TextBox();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 16);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Meadow IP";
            // 
            // meadowIpTextbox
            // 
            meadowIpTextbox.Location = new Point(6, 38);
            meadowIpTextbox.Margin = new Padding(1);
            meadowIpTextbox.Name = "meadowIpTextbox";
            meadowIpTextbox.Size = new Size(113, 27);
            meadowIpTextbox.TabIndex = 1;
            meadowIpTextbox.Text = "192.168.51.125";
            meadowIpTextbox.TextAlign = HorizontalAlignment.Right;
            // 
            // sendTextBox
            // 
            sendTextBox.AcceptsReturn = true;
            sendTextBox.Location = new Point(6, 99);
            sendTextBox.Margin = new Padding(1);
            sendTextBox.Multiline = true;
            sendTextBox.Name = "sendTextBox";
            sendTextBox.Size = new Size(611, 30);
            sendTextBox.TabIndex = 4;
            sendTextBox.Text = "This is a message to send. 0123456789";
            // 
            // recvTextBox
            // 
            recvTextBox.AcceptsReturn = true;
            recvTextBox.Location = new Point(14, 229);
            recvTextBox.Margin = new Padding(1);
            recvTextBox.Multiline = true;
            recvTextBox.Name = "recvTextBox";
            recvTextBox.ReadOnly = true;
            recvTextBox.ScrollBars = ScrollBars.Vertical;
            recvTextBox.Size = new Size(602, 156);
            recvTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 0;
            label2.Text = "Text To Send";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 203);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 0;
            label3.Text = "Received Messages";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(103, 165);
            sendButton.Margin = new Padding(1);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(63, 37);
            sendButton.TabIndex = 6;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // sendCntTextBox
            // 
            sendCntTextBox.Location = new Point(260, 160);
            sendCntTextBox.Margin = new Padding(1);
            sendCntTextBox.Name = "sendCntTextBox";
            sendCntTextBox.ReadOnly = true;
            sendCntTextBox.Size = new Size(75, 27);
            sendCntTextBox.TabIndex = 7;
            sendCntTextBox.Text = "0";
            sendCntTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // recvCntTextBox
            // 
            recvCntTextBox.Location = new Point(192, 160);
            recvCntTextBox.Margin = new Padding(1);
            recvCntTextBox.Name = "recvCntTextBox";
            recvCntTextBox.ReadOnly = true;
            recvCntTextBox.Size = new Size(66, 27);
            recvCntTextBox.TabIndex = 8;
            recvCntTextBox.Text = "0";
            recvCntTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 139);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 0;
            label4.Text = "# Received";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 139);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 0;
            label5.Text = "# Sent";
            // 
            // connectButton
            // 
            connectButton.Location = new Point(229, 31);
            connectButton.Margin = new Padding(1);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(84, 33);
            connectButton.TabIndex = 9;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // ipPortTextBox
            // 
            ipPortTextBox.Location = new Point(125, 38);
            ipPortTextBox.Margin = new Padding(1);
            ipPortTextBox.Name = "ipPortTextBox";
            ipPortTextBox.Size = new Size(88, 27);
            ipPortTextBox.TabIndex = 1;
            ipPortTextBox.Text = "65123";
            ipPortTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 16);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 0;
            label6.Text = "Meadow Port";
            // 
            // statusTextBox
            // 
            statusTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            statusTextBox.Location = new Point(14, 425);
            statusTextBox.Margin = new Padding(1);
            statusTextBox.Multiline = true;
            statusTextBox.Name = "statusTextBox";
            statusTextBox.ReadOnly = true;
            statusTextBox.ScrollBars = ScrollBars.Vertical;
            statusTextBox.Size = new Size(602, 73);
            statusTextBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 398);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 0;
            label7.Text = "Status";
            // 
            // sendCountTextbox
            // 
            sendCountTextbox.Location = new Point(94, 136);
            sendCountTextbox.Margin = new Padding(1);
            sendCountTextbox.Name = "sendCountTextbox";
            sendCountTextbox.Size = new Size(82, 27);
            sendCountTextbox.TabIndex = 12;
            sendCountTextbox.Text = "1";
            sendCountTextbox.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 136);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 13;
            label9.Text = "Send Count";
            // 
            // genRandomMsgCheckBox
            // 
            genRandomMsgCheckBox.AutoSize = true;
            genRandomMsgCheckBox.Location = new Point(152, 76);
            genRandomMsgCheckBox.Margin = new Padding(1);
            genRandomMsgCheckBox.Name = "genRandomMsgCheckBox";
            genRandomMsgCheckBox.Size = new Size(151, 24);
            genRandomMsgCheckBox.TabIndex = 14;
            genRandomMsgCheckBox.Text = "Generate Random";
            genRandomMsgCheckBox.UseVisualStyleBackColor = true;
            genRandomMsgCheckBox.CheckedChanged += genRandomMsgCheckBox_CheckedChanged;
            // 
            // matchCntTextBox
            // 
            matchCntTextBox.Location = new Point(337, 160);
            matchCntTextBox.Margin = new Padding(1);
            matchCntTextBox.Name = "matchCntTextBox";
            matchCntTextBox.ReadOnly = true;
            matchCntTextBox.Size = new Size(72, 27);
            matchCntTextBox.TabIndex = 7;
            matchCntTextBox.Text = "0";
            matchCntTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // mismatchCntTextBox
            // 
            mismatchCntTextBox.Location = new Point(432, 160);
            mismatchCntTextBox.Margin = new Padding(1);
            mismatchCntTextBox.Name = "mismatchCntTextBox";
            mismatchCntTextBox.ReadOnly = true;
            mismatchCntTextBox.Size = new Size(63, 27);
            mismatchCntTextBox.TabIndex = 7;
            mismatchCntTextBox.Text = "0";
            mismatchCntTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(337, 136);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 0;
            label8.Text = "# Success";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(439, 136);
            label10.Margin = new Padding(1, 0, 1, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 0;
            label10.Text = "# Errors";
            // 
            // totalExecTimeTextBox
            // 
            totalExecTimeTextBox.Location = new Point(516, 162);
            totalExecTimeTextBox.Margin = new Padding(1);
            totalExecTimeTextBox.Name = "totalExecTimeTextBox";
            totalExecTimeTextBox.ReadOnly = true;
            totalExecTimeTextBox.Size = new Size(100, 27);
            totalExecTimeTextBox.TabIndex = 7;
            totalExecTimeTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(542, 136);
            label11.Margin = new Padding(1, 0, 1, 0);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 0;
            label11.Text = "Time";
            // 
            // label12
            // 
            label12.Location = new Point(337, 31);
            label12.Name = "label12";
            label12.Size = new Size(247, 45);
            label12.TabIndex = 15;
            label12.Text = "To start the Meadow chat server use developer -d 5 -v 0\r\n";
            // 
            // MeadowEthChatUi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 515);
            Controls.Add(label12);
            Controls.Add(genRandomMsgCheckBox);
            Controls.Add(label9);
            Controls.Add(sendCountTextbox);
            Controls.Add(statusTextBox);
            Controls.Add(connectButton);
            Controls.Add(recvCntTextBox);
            Controls.Add(totalExecTimeTextBox);
            Controls.Add(mismatchCntTextBox);
            Controls.Add(matchCntTextBox);
            Controls.Add(sendCntTextBox);
            Controls.Add(sendButton);
            Controls.Add(recvTextBox);
            Controls.Add(sendTextBox);
            Controls.Add(ipPortTextBox);
            Controls.Add(meadowIpTextbox);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label1);
            Margin = new Padding(1);
            Name = "MeadowEthChatUi";
            Text = "Meadow Chat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox meadowIpTextbox;
        private TextBox sendTextBox;
        private TextBox recvTextBox;
        private Label label2;
        private Label label3;
        private Button sendButton;
        private TextBox sendCntTextBox;
        private TextBox recvCntTextBox;
        private Label label4;
        private Label label5;
        private Button connectButton;
        private TextBox ipPortTextBox;
        private Label label6;
        private TextBox statusTextBox;
        private Label label7;
        private TextBox sendCountTextbox;
        private Label label9;
        private CheckBox genRandomMsgCheckBox;
        private TextBox matchCntTextBox;
        private TextBox mismatchCntTextBox;
        private Label label8;
        private Label label10;
        private TextBox totalExecTimeTextBox;
        private Label label11;
        private Label label12;
    }
}

