namespace TestWork.EmailSend
{
    partial class EmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailForm));
            this.tbSendFrom = new System.Windows.Forms.TextBox();
            this.tbSendTo = new System.Windows.Forms.TextBox();
            this.tbSendTheme = new System.Windows.Forms.TextBox();
            this.tbSendBody = new System.Windows.Forms.TextBox();
            this.tbSendFile = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSendSearchFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSendFrom
            // 
            this.tbSendFrom.Location = new System.Drawing.Point(111, 12);
            this.tbSendFrom.Name = "tbSendFrom";
            this.tbSendFrom.Size = new System.Drawing.Size(213, 22);
            this.tbSendFrom.TabIndex = 0;
            // 
            // tbSendTo
            // 
            this.tbSendTo.Location = new System.Drawing.Point(111, 42);
            this.tbSendTo.Name = "tbSendTo";
            this.tbSendTo.Size = new System.Drawing.Size(213, 22);
            this.tbSendTo.TabIndex = 0;
            // 
            // tbSendTheme
            // 
            this.tbSendTheme.Location = new System.Drawing.Point(111, 72);
            this.tbSendTheme.Name = "tbSendTheme";
            this.tbSendTheme.Size = new System.Drawing.Size(213, 22);
            this.tbSendTheme.TabIndex = 0;
            // 
            // tbSendBody
            // 
            this.tbSendBody.Location = new System.Drawing.Point(111, 143);
            this.tbSendBody.Multiline = true;
            this.tbSendBody.Name = "tbSendBody";
            this.tbSendBody.Size = new System.Drawing.Size(213, 120);
            this.tbSendBody.TabIndex = 0;
            // 
            // tbSendFile
            // 
            this.tbSendFile.Location = new System.Drawing.Point(111, 102);
            this.tbSendFile.Name = "tbSendFile";
            this.tbSendFile.Size = new System.Drawing.Size(166, 22);
            this.tbSendFile.TabIndex = 0;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(12, 272);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(312, 37);
            this.btSend.TabIndex = 1;
            this.btSend.Text = "Отправить";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "От:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кому:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тема:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Тело письма:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Файл:";
            // 
            // btSendSearchFile
            // 
            this.btSendSearchFile.Image = ((System.Drawing.Image)(resources.GetObject("btSendSearchFile.Image")));
            this.btSendSearchFile.Location = new System.Drawing.Point(283, 100);
            this.btSendSearchFile.Name = "btSendSearchFile";
            this.btSendSearchFile.Size = new System.Drawing.Size(41, 37);
            this.btSendSearchFile.TabIndex = 3;
            this.btSendSearchFile.UseVisualStyleBackColor = true;
            this.btSendSearchFile.Click += new System.EventHandler(this.btSendSearchFile_Click);
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(336, 321);
            this.Controls.Add(this.btSendSearchFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbSendFile);
            this.Controls.Add(this.tbSendBody);
            this.Controls.Add(this.tbSendTheme);
            this.Controls.Add(this.tbSendTo);
            this.Controls.Add(this.tbSendFrom);
            this.Name = "EmailForm";
            this.Text = "Отправить...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSendFrom;
        private System.Windows.Forms.TextBox tbSendTo;
        private System.Windows.Forms.TextBox tbSendTheme;
        private System.Windows.Forms.TextBox tbSendBody;
        private System.Windows.Forms.TextBox tbSendFile;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSendSearchFile;
    }
}