using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestWork.DataBase;
using TestWork.Frontend;
using TestWork.Template;

namespace TestWork
{
    public partial class TemplateBuilder : Form
    {
        private readonly SettingsManager _settingsManager;
        private TemplateProcessor _templateProcessor;
        string templatePath;
        public TemplateBuilder()
        {
            InitializeComponent();
            string dbPath = @"C:\Users\1\source\repos\TestWork\TestWork\DataBase\test_work.sqlite";
            DBInitializer.Initialize(dbPath);
            _settingsManager = new SettingsManager(); // Инициализация SettingsManager
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings(_settingsManager);
            settingsForm.ShowDialog();
        }

        private void SelectTemplate_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = _settingsManager.Settings.TemplatePath,
                Filter = "Word Documents|*.docx",
                Title = "Выберите шаблон документа"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _templateProcessor = new TemplateProcessor();
                templatePath = openFileDialog.FileName;
                _templateProcessor.CreateDocumentFromTemplate(templatePath);

                // Извлекаем поля и отображаем их для заполнения
                var fields = _templateProcessor.GetTemplateFields();
                _templateProcessor.DisplayFieldsForFilling(this, fields);
            }
        }

        private void btFillFieldTemplate_Click(object sender, EventArgs e)
        {
            _templateProcessor = new TemplateProcessor();
            _templateProcessor.CreateDocumentFromTemplate(templatePath);
            // Получаем значения полей от пользователя
            Dictionary<string, string> fieldValues = _templateProcessor.GetFieldValuesFromUserInput(this);

            foreach (var field in fieldValues)
            {
                _templateProcessor.FillField(field.Key, field.Value);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = _settingsManager.Settings.DefaultSavePath,
                Filter = "Word Documents|*.docx",
                Title = "Сохраните заполненный документ"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                _templateProcessor.SaveFilledDocument(savePath);
                MessageBox.Show("Документ успешно сохранен.");
            }

            _templateProcessor.Close();
        }
    }

}
