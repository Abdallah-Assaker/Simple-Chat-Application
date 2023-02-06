namespace ClientUI
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.txtRecievedMsg = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersComboBox
            // 
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(657, 161);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(127, 21);
            this.usersComboBox.TabIndex = 20;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(657, 72);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(127, 56);
            this.stopBtn.TabIndex = 18;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // txtRecievedMsg
            // 
            this.txtRecievedMsg.BackColor = System.Drawing.Color.White;
            this.txtRecievedMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecievedMsg.Location = new System.Drawing.Point(17, 10);
            this.txtRecievedMsg.Multiline = true;
            this.txtRecievedMsg.Name = "txtRecievedMsg";
            this.txtRecievedMsg.ReadOnly = true;
            this.txtRecievedMsg.Size = new System.Drawing.Size(634, 363);
            this.txtRecievedMsg.TabIndex = 17;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(657, 377);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(127, 61);
            this.sendBtn.TabIndex = 16;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(17, 379);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(634, 61);
            this.txtMsg.TabIndex = 15;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(657, 10);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(127, 56);
            this.startBtn.TabIndex = 14;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usersComboBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.txtRecievedMsg);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.startBtn);
            this.Name = "ClientForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox txtRecievedMsg;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button startBtn;
    }
}

