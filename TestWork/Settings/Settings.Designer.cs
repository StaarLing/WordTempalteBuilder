namespace TestWork
{
    partial class Settings
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
            this.btSaveSettings = new System.Windows.Forms.Button();
            this.tbTemplatePath = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPathToSaveFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmailPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSaveSettings
            // 
            this.btSaveSettings.Location = new System.Drawing.Point(15, 235);
            this.btSaveSettings.Name = "btSaveSettings";
            this.btSaveSettings.Size = new System.Drawing.Size(382, 43);
            this.btSaveSettings.TabIndex = 0;
            this.btSaveSettings.Text = "Сохранить";
            this.btSaveSettings.UseVisualStyleBackColor = true;
            this.btSaveSettings.Click += new System.EventHandler(this.btSaveSettings_Click);
            // 
            // tbTemplatePath
            // 
            this.tbTemplatePath.Location = new System.Drawing.Point(242, 89);
            this.tbTemplatePath.Name = "tbTemplatePath";
            this.tbTemplatePath.Size = new System.Drawing.Size(155, 22);
            this.tbTemplatePath.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(242, 140);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(155, 22);
            this.tbEmail.TabIndex = 1;
            // 
            // tbPathToSaveFile
            // 
            this.tbPathToSaveFile.Location = new System.Drawing.Point(242, 35);
            this.tbPathToSaveFile.Name = "tbPathToSaveFile";
            this.tbPathToSaveFile.Size = new System.Drawing.Size(155, 22);
            this.tbPathToSaveFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Место сохранения по умолчанию:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Путь к шаблонам по умолчанию:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email по умолчанию:";
            // 
            // tbEmailPass
            // 
            this.tbEmailPass.Location = new System.Drawing.Point(242, 187);
            this.tbEmailPass.Name = "tbEmailPass";
            this.tbEmailPass.Size = new System.Drawing.Size(155, 22);
            this.tbEmailPass.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Пароль Email по умолчанию:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 290);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmailPass);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTemplatePath);
            this.Controls.Add(this.tbPathToSaveFile);
            this.Controls.Add(this.btSaveSettings);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSaveSettings;
        private System.Windows.Forms.TextBox tbTemplatePath;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPathToSaveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmailPass;
        private System.Windows.Forms.Label label4;
    }
}