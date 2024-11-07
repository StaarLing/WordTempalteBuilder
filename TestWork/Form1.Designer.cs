namespace TestWork
{
    partial class TemplateBuilder
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateBuilder));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.SendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.AboutProgramm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectTemplate,
            this.SaveFileAs,
            this.SendEmail,
            this.Settings});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // SelectTemplate
            // 
            this.SelectTemplate.Name = "SelectTemplate";
            this.SelectTemplate.Size = new System.Drawing.Size(224, 26);
            this.SelectTemplate.Text = "Выбор шаблона...";
            // 
            // SaveFileAs
            // 
            this.SaveFileAs.Name = "SaveFileAs";
            this.SaveFileAs.Size = new System.Drawing.Size(224, 26);
            this.SaveFileAs.Text = "Сохранить в...";
            // 
            // SendEmail
            // 
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(224, 26);
            this.SendEmail.Text = "Отправить...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(14, 24);
            // 
            // AboutProgramm
            // 
            this.AboutProgramm.Name = "AboutProgramm";
            this.AboutProgramm.Size = new System.Drawing.Size(118, 24);
            this.AboutProgramm.Text = "О программе";
            // 
            // Settings
            // 
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(224, 26);
            this.Settings.Text = "Настройки";
            // 
            // TemplateBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TemplateBuilder";
            this.Text = "Tempalte Builder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SelectTemplate;
        private System.Windows.Forms.ToolStripMenuItem SaveFileAs;
        private System.Windows.Forms.ToolStripMenuItem SendEmail;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramm;
    }
}

