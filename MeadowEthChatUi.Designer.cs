
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
            this.label1 = new System.Windows.Forms.Label();
            this.meadowIpTextbox = new System.Windows.Forms.TextBox();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.recvTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.sendCntTextBox = new System.Windows.Forms.TextBox();
            this.recvCntTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.ipPortTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sendCountTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.genRandomMsgCheckBox = new System.Windows.Forms.CheckBox();
            this.matchCntTextBox = new System.Windows.Forms.TextBox();
            this.mismatchCntTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalExecTimeTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meadow IP";
            // 
            // meadowIpTextbox
            // 
            this.meadowIpTextbox.Location = new System.Drawing.Point(12, 77);
            this.meadowIpTextbox.Name = "meadowIpTextbox";
            this.meadowIpTextbox.Size = new System.Drawing.Size(236, 47);
            this.meadowIpTextbox.TabIndex = 1;
            this.meadowIpTextbox.Text = "192.168.2.201";
            this.meadowIpTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sendTextBox
            // 
            this.sendTextBox.AcceptsReturn = true;
            this.sendTextBox.Location = new System.Drawing.Point(12, 203);
            this.sendTextBox.Multiline = true;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(1293, 57);
            this.sendTextBox.TabIndex = 4;
            this.sendTextBox.Text = "This is a message to send. 0123456789";
            // 
            // recvTextBox
            // 
            this.recvTextBox.AcceptsReturn = true;
            this.recvTextBox.Location = new System.Drawing.Point(30, 470);
            this.recvTextBox.Multiline = true;
            this.recvTextBox.Name = "recvTextBox";
            this.recvTextBox.ReadOnly = true;
            this.recvTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recvTextBox.Size = new System.Drawing.Size(1275, 315);
            this.recvTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Text To Send";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Received Messages";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(199, 332);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(133, 53);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Start";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // sendCntTextBox
            // 
            this.sendCntTextBox.Location = new System.Drawing.Point(579, 329);
            this.sendCntTextBox.Name = "sendCntTextBox";
            this.sendCntTextBox.ReadOnly = true;
            this.sendCntTextBox.Size = new System.Drawing.Size(130, 47);
            this.sendCntTextBox.TabIndex = 7;
            this.sendCntTextBox.Text = "0";
            this.sendCntTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // recvCntTextBox
            // 
            this.recvCntTextBox.Location = new System.Drawing.Point(415, 329);
            this.recvCntTextBox.Name = "recvCntTextBox";
            this.recvCntTextBox.ReadOnly = true;
            this.recvCntTextBox.Size = new System.Drawing.Size(130, 47);
            this.recvCntTextBox.TabIndex = 8;
            this.recvCntTextBox.Text = "0";
            this.recvCntTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "# Received";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = "# Sent";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(486, 77);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(178, 54);
            this.connectButton.TabIndex = 9;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // ipPortTextBox
            // 
            this.ipPortTextBox.Location = new System.Drawing.Point(265, 77);
            this.ipPortTextBox.Name = "ipPortTextBox";
            this.ipPortTextBox.Size = new System.Drawing.Size(183, 47);
            this.ipPortTextBox.TabIndex = 1;
            this.ipPortTextBox.Text = "65123";
            this.ipPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Meadow Port";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.statusTextBox.Location = new System.Drawing.Point(30, 872);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statusTextBox.Size = new System.Drawing.Size(1275, 262);
            this.statusTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 816);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 41);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status";
            // 
            // sendCountTextbox
            // 
            this.sendCountTextbox.Location = new System.Drawing.Point(199, 279);
            this.sendCountTextbox.Name = "sendCountTextbox";
            this.sendCountTextbox.Size = new System.Drawing.Size(133, 47);
            this.sendCountTextbox.TabIndex = 12;
            this.sendCountTextbox.Text = "1";
            this.sendCountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 41);
            this.label9.TabIndex = 13;
            this.label9.Text = "Send Count";
            // 
            // genRandomMsgCheckBox
            // 
            this.genRandomMsgCheckBox.AutoSize = true;
            this.genRandomMsgCheckBox.Location = new System.Drawing.Point(324, 155);
            this.genRandomMsgCheckBox.Name = "genRandomMsgCheckBox";
            this.genRandomMsgCheckBox.Size = new System.Drawing.Size(297, 45);
            this.genRandomMsgCheckBox.TabIndex = 14;
            this.genRandomMsgCheckBox.Text = "Generate Random";
            this.genRandomMsgCheckBox.UseVisualStyleBackColor = true;
            this.genRandomMsgCheckBox.CheckedChanged += new System.EventHandler(this.genRandomMsgCheckBox_CheckedChanged);
            // 
            // matchCntTextBox
            // 
            this.matchCntTextBox.Location = new System.Drawing.Point(736, 329);
            this.matchCntTextBox.Name = "matchCntTextBox";
            this.matchCntTextBox.ReadOnly = true;
            this.matchCntTextBox.Size = new System.Drawing.Size(130, 47);
            this.matchCntTextBox.TabIndex = 7;
            this.matchCntTextBox.Text = "0";
            this.matchCntTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mismatchCntTextBox
            // 
            this.mismatchCntTextBox.Location = new System.Drawing.Point(917, 329);
            this.mismatchCntTextBox.Name = "mismatchCntTextBox";
            this.mismatchCntTextBox.ReadOnly = true;
            this.mismatchCntTextBox.Size = new System.Drawing.Size(130, 47);
            this.mismatchCntTextBox.TabIndex = 7;
            this.mismatchCntTextBox.Text = "0";
            this.mismatchCntTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(716, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 41);
            this.label8.TabIndex = 0;
            this.label8.Text = "# Success";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(933, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 41);
            this.label10.TabIndex = 0;
            this.label10.Text = "# Errors";
            // 
            // totalExecTimeTextBox
            // 
            this.totalExecTimeTextBox.Location = new System.Drawing.Point(1107, 332);
            this.totalExecTimeTextBox.Name = "totalExecTimeTextBox";
            this.totalExecTimeTextBox.ReadOnly = true;
            this.totalExecTimeTextBox.Size = new System.Drawing.Size(198, 47);
            this.totalExecTimeTextBox.TabIndex = 7;
            this.totalExecTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1152, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 41);
            this.label11.TabIndex = 0;
            this.label11.Text = "Time";
            // 
            // MeadowEthChatUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 1170);
            this.Controls.Add(this.genRandomMsgCheckBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sendCountTextbox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.recvCntTextBox);
            this.Controls.Add(this.totalExecTimeTextBox);
            this.Controls.Add(this.mismatchCntTextBox);
            this.Controls.Add(this.matchCntTextBox);
            this.Controls.Add(this.sendCntTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.recvTextBox);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.ipPortTextBox);
            this.Controls.Add(this.meadowIpTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "MeadowEthChatUi";
            this.Text = "Meadow Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox meadowIpTextbox;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.TextBox recvTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox sendCntTextBox;
        private System.Windows.Forms.TextBox recvCntTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox ipPortTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sendCountTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox genRandomMsgCheckBox;
        private System.Windows.Forms.TextBox matchCntTextBox;
        private System.Windows.Forms.TextBox mismatchCntTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalExecTimeTextBox;
        private System.Windows.Forms.Label label11;
    }
}

