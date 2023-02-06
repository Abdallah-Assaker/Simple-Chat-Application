namespace ServerUI
{
    partial class ServerForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.userName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.abortBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.userName});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 28);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(224, 236);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // userName
            // 
            this.userName.Text = "UserName";
            this.userName.Width = 145;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 75;
            // 
            // connectionPanel
            // 
            this.connectionPanel.BackColor = System.Drawing.Color.Red;
            this.connectionPanel.Location = new System.Drawing.Point(15, 7);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(16, 15);
            this.connectionPanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Connected Devices : 0";
            // 
            // abortBtn
            // 
            this.abortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abortBtn.Location = new System.Drawing.Point(15, 328);
            this.abortBtn.Name = "abortBtn";
            this.abortBtn.Size = new System.Drawing.Size(224, 23);
            this.abortBtn.TabIndex = 9;
            this.abortBtn.Text = "Abort";
            this.abortBtn.UseVisualStyleBackColor = true;
            this.abortBtn.Click += new System.EventHandler(this.abortBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(15, 299);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(224, 23);
            this.removeBtn.TabIndex = 8;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(15, 270);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(224, 23);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "Turn on";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 358);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.connectionPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abortBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.startBtn);
            this.Name = "ServerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader userName;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button abortBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button startBtn;
    }
}

