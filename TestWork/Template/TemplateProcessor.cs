using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWork.Template
{
    public class TemplateProcessor
    {
        private Microsoft.Office.Interop.Word.Application _wordApp;
        private Document _document;
        private string templatePaths;

        public TemplateProcessor()
        {
            // Инициализация Word приложения
            _wordApp = new Microsoft.Office.Interop.Word.Application();
            _document = new Document();
            _wordApp.Visible = false;
        }

        // Создание нового документа на основе шаблона
        public void CreateDocumentFromTemplate(string templatePath)
        {
            try
            {
                // Открытие нового документа на основе шаблона
                _document = _wordApp.Documents.Add(templatePath);
                templatePaths = templatePath; // Сохраняем путь шаблона
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании документа: {ex.Message}");
                Close(); // Закрываем Word в случае ошибки
            }
        }

        // Извлечение полей для заполнения
        public List<string> GetTemplateFields()
        {
            var fields = new List<string>();
            // Перебираем закладки в документе
            foreach (Bookmark bookmark in _document.Bookmarks)
            {
                fields.Add(bookmark.Name); // Добавляем имя закладки в список
            }

            return fields;
        }

        // Заполнение полей в документе
        public void FillField(string fieldName, string value)
        {

            if (_document == null)
            {
                throw new InvalidOperationException("Документ не был инициализирован.");
            }

            try
            {
                if (_document.Bookmarks.Exists(fieldName))
                {
                    Microsoft.Office.Interop.Word.Bookmark bookmark = _document.Bookmarks[fieldName];
                    bookmark.Range.Text = value;

                    // Освобождаем объект bookmark, чтобы избежать утечек памяти
                    Marshal.ReleaseComObject(bookmark);
                }
                else
                {
                    Console.WriteLine($"Поле с именем '{fieldName}' не найдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при заполнении поля '{fieldName}': {ex.Message}");
            }
        }


        // Сохранение заполненного документа
        public void SaveFilledDocument(string savePath)
        {
            if (_document == null)
            {
                throw new InvalidOperationException("Документ не был инициализирован.");
            }

            try
            {
                _document.SaveAs2(savePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении документа: {ex.Message}");
            }
        }

        // Закрытие Word приложения
        public void Close()
        {
            try
            {
                if (_document != null)
                {
                    _document.Close(false);
                    Marshal.ReleaseComObject(_document);
                    _document = null;
                }

                if (_wordApp != null)
                {
                    _wordApp.Quit();
                    Marshal.ReleaseComObject(_wordApp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при закрытии Word: {ex.Message}");
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
            public void DisplayFieldsForFilling(Form form, List<string> fields)
        {
            // Получаем ссылку на FlowLayoutPanel в форме
            FlowLayoutPanel fieldsFlowLayoutPanel = form.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();

            // Проверяем, что FlowLayoutPanel существует
            if (fieldsFlowLayoutPanel == null)
            {
                throw new ArgumentNullException("FlowLayoutPanel не найден на форме.");
            }

            // Очистка старых элементов перед добавлением новых
            fieldsFlowLayoutPanel.Controls.Clear();

            // Устанавливаем направление и отступы для FlowLayoutPanel
            fieldsFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            fieldsFlowLayoutPanel.WrapContents = true; // чтобы элементы переходили на следующую строку
            fieldsFlowLayoutPanel.Padding = new Padding(10); // Внутренний отступ панели
            fieldsFlowLayoutPanel.AutoScroll = true; // Включаем прокрутку

            // Перебираем список полей и создаем соответствующие элементы
            foreach (var field in fields)
            {
                // Создаем label для отображения названия поля
                Label fieldLabel = new Label
                {
                    Text = field, // Имя поля
                    AutoSize = true,
                    Margin = new Padding(5, 10, 5, 0) // Отступы для label
                };

                // Создаем текстовое поле для ввода данных
                TextBox fieldTextBox = new TextBox
                {
                    Name = field, // Присваиваем уникальное имя
                    Width = 200, // Устанавливаем ширину текстового поля
                    Margin = new Padding(5, 5, 5, 10) // Отступы для TextBox
                };

                // Добавляем элементы в FlowLayoutPanel
                fieldsFlowLayoutPanel.Controls.Add(fieldLabel);
                fieldsFlowLayoutPanel.Controls.Add(fieldTextBox);
            }
        }

        public Dictionary<string, string> GetFieldValuesFromUserInput(Form form)
        {
            var fieldValues = new Dictionary<string, string>();

            foreach (Control control in form.Controls.OfType<FlowLayoutPanel>().FirstOrDefault().Controls)
            {
                if (control is TextBox textBox)
                {
                    string fieldName = textBox.Name; // Имя поля
                    string fieldValue = textBox.Text; // Значение, введенное пользователем
                    fieldValues.Add(fieldName, fieldValue);
                }
            }

            return fieldValues;
        }
    }
}