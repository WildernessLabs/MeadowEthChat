
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
            this.label8 = new System.Windows.Forms.Label();
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
            this.meadowIpTextbox.Text = "192.168.2.135";
            this.meadowIpTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sendTextBox
            // 
            this.sendTextBox.AcceptsReturn = true;
            this.sendTextBox.Location = new System.Drawing.Point(30, 252);
            this.sendTextBox.Multiline = true;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(1047, 134);
            this.sendTextBox.TabIndex = 4;
            this.sendTextBox.Text = "This is a message to send. 0123456789";
            // 
            // recvTextBox
            // 
            this.recvTextBox.AcceptsReturn = true;
            this.recvTextBox.Location = new System.Drawing.Point(30, 454);
            this.recvTextBox.Multiline = true;
            this.recvTextBox.Name = "recvTextBox";
            this.recvTextBox.ReadOnly = true;
            this.recvTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recvTextBox.Size = new System.Drawing.Size(1275, 331);
            this.recvTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Message To Send";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Received Messages";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(1100, 290);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(178, 53);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // sendCntTextBox
            // 
            this.sendCntTextBox.Location = new System.Drawing.Point(1049, 77);
            this.sendCntTextBox.Name = "sendCntTextBox";
            this.sendCntTextBox.ReadOnly = true;
            this.sendCntTextBox.Size = new System.Drawing.Size(149, 47);
            this.sendCntTextBox.TabIndex = 7;
            this.sendCntTextBox.Text = "0";
            this.sendCntTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // recvCntTextBox
            // 
            this.recvCntTextBox.Location = new System.Drawing.Point(842, 77);
            this.recvCntTextBox.Name = "recvCntTextBox";
            this.recvCntTextBox.ReadOnly = true;
            this.recvCntTextBox.Size = new System.Drawing.Size(155, 47);
            this.recvCntTextBox.TabIndex = 8;
            this.recvCntTextBox.Text = "0";
            this.recvCntTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(835, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "# Received";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1044, 33);
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
            this.statusTextBox.Location = new System.Drawing.Point(30, 872);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statusTextBox.Size = new System.Drawing.Size(1275, 232);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(543, 41);
            this.label8.TabIndex = 11;
            this.label8.Text = "-> See Readme.txt in code for usage <-";
            // 
            // MeadowChatUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 1170);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.recvCntTextBox);
            this.Controls.Add(this.sendCntTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.recvTextBox);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.ipPortTextBox);
            this.Controls.Add(this.meadowIpTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "MeadowChatUi";
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
        private System.Windows.Forms.Label label8;
    }
}

