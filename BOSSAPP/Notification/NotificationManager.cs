using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSSAPP.Notification
{
    public class NotificationManager
    {
        private NotificationConfigManager configManager;
        private NotificationForm notificationForm;

        private string notificationsFilePath = @"D:\1.Programming\BOSSAPP\BOSSAPP\Notification\notificationJson.json";

        private List<Notification> notifications;

        public NotificationManager(NotificationConfigManager configManager)
        {
            this.configManager = configManager;

            notifications = new List<Notification>();
        }

        public void TriggerNotification(string trigger, Dictionary<string, string> parameters)
        {
            var config = configManager.GetConfig(trigger);
            if (config != null)
            {
                string message = config.MessageTemplate;
                foreach (var param in parameters)
                {
                    message = message.Replace($"{{{param.Key}}}", param.Value);
                }

                notifications.Add(new Notification
                {
                    Title = config.Title,
                    Message = message,
                });

                SaveNotificationsToJson();
            }
        }

        private void SaveNotificationsToJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(notifications, Formatting.Indented);
                File.WriteAllText(notificationsFilePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving notifications to JSON: {ex.Message}");
            }
        }
    }
}
