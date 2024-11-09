using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestWork.Frontend
{
    public class SettingsManager
    {
        private readonly string _settingsFile = "C:\\Users\\1\\source\\repos\\TestWork\\TestWork\\settings.json";
        public UserSettings Settings { get; private set; }

        public SettingsManager()
        {
            LoadSettings();
        }

        public void LoadSettings()
        {
            if (File.Exists(_settingsFile))
            {
                var json = File.ReadAllText(_settingsFile);
                Settings = JsonConvert.DeserializeObject<UserSettings>(json);
            }
            else
            {
                Settings = new UserSettings(); // значения по умолчанию
            }
        }

        public void SaveSettings()
        {
            var json = JsonConvert.SerializeObject(Settings, Formatting.Indented);
            File.WriteAllText(_settingsFile, json);
        }
    }

    public class UserSettings
    {
        public string TemplatePath { get; set; } = "C:\\Users\\1\\source\\repos\\TestWork\\Templates";
        public string DefaultSavePath { get; set; } = "C:\\Users\\1\\source\\repos\\TestWork\\SavedDocuments";
        public string UserEmail { get; set; } = "user@example.com";
    }
}