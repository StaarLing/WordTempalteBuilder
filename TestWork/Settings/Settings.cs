using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWork.Frontend;

namespace TestWork
{
    public partial class Settings : Form
    {
        private readonly SettingsManager _settingsManager;
        public Settings(SettingsManager settingsManager)
        {
            InitializeComponent();
            _settingsManager = settingsManager;

            // Заполнение полей текущими настройками
            tbTemplatePath.Text = _settingsManager.Settings.TemplatePath;
            tbPathToSaveFile.Text = _settingsManager.Settings.DefaultSavePath;
            tbEmail.Text = _settingsManager.Settings.UserEmail;
        }

        private void btSaveSettings_Click(object sender, EventArgs e)
        {
            // Обновляем настройки
            _settingsManager.Settings.TemplatePath = tbTemplatePath.Text;
            _settingsManager.Settings.DefaultSavePath = tbPathToSaveFile.Text;
            _settingsManager.Settings.UserEmail = tbEmail.Text;

            // Сохраняем настройки в файл
            _settingsManager.SaveSettings();
            MessageBox.Show("Настройки сохранены.");
            this.Close();
        }
    }
}
