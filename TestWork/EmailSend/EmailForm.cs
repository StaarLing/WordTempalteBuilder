using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using TestWork.Frontend;
using TestWork.Template;
using Microsoft.Office.Interop.Word;
using System.Xml.Linq;

namespace TestWork.EmailSend
{
    public partial class EmailForm : Form
    {
        private readonly SettingsManager _settingsManager;
        private string filePath;
        public EmailForm()
        {
            InitializeComponent();
            _settingsManager = new SettingsManager();
            tbSendFrom.Text = _settingsManager.Settings.UserEmail;
        }

        private void btSendSearchFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = _settingsManager.Settings.DefaultSavePath,
                Filter = "Word Documents|*.docx",
                Title = "Выберите файл для отправки"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                tbSendFile.Text = filePath;
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            // Параметры для отправки почты
            string smtpServer = "smtp.mail.ru";
            int smtpPort = 587;
            string smtpUser = tbSendFrom.Text;  // Ваш email
            string smtpPassword = _settingsManager.Settings.UserEmailPass; // Ваш пароль
            string fromEmail = tbSendFrom.Text; // Отправитель
            string toEmail = tbSendTo.Text;  // Получатель
            string body = tbSendBody.Text; // Тело письма
            string subject = tbSendTheme.Text;
            string attachmentFilePath = filePath; // Путь к файлу для отправки

            // Отправляем письмо
            SendEmailWithAttachment(smtpServer, smtpPort, smtpUser, smtpPassword, fromEmail, toEmail, subject, body, attachmentFilePath);
        }
        public void SendEmailWithAttachment(string smtpServer, int smtpPort, string smtpUser, string smtpPassword, string fromEmail, string toEmail, string subject, string body, string attachmentFilePath)
        {
            try
            {
                // Создаем объект MailMessage для письма
                System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
                mailMessage.From = new MailAddress(fromEmail);  // Отправитель
                mailMessage.To.Add(toEmail);                   // Получатель
                mailMessage.Subject = subject;                 // Тема письма
                mailMessage.Body = body;                       // Текст письма

                // Добавляем файл в качестве вложения
                mailMessage.Attachments.Add(new Attachment(attachmentFilePath));

                // Создаем объект SmtpClient для отправки письма
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort)
                {
                    Credentials = new NetworkCredential(smtpUser, smtpPassword), // Учетные данные для авторизации на сервере
                    EnableSsl = true // Использование защищенного соединения
                };

                // Отправляем письмо
                smtpClient.Send(mailMessage);
                Console.WriteLine("Письмо отправлено успешно!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при отправке письма: {ex.Message}");
            }
        }
    }
}
