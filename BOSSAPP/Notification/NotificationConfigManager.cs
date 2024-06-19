using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSSAPP.Notification
{
    public class NotificationConfigManager
    {
        private List<NotificationConfig> configs;

        public NotificationConfigManager(string configFilePath)
        {
            LoadConfigs(configFilePath);
        }

        private void LoadConfigs(string configFilePath)
        {
            try
            {
                string jsonData = System.IO.File.ReadAllText(configFilePath);
                configs = JsonConvert.DeserializeObject<List<NotificationConfig>>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading notification configurations: {ex.Message}");
                configs = new List<NotificationConfig>();
            }
        }

        public NotificationConfig GetConfig(string trigger)
        {
            return configs.FirstOrDefault(config => config.Trigger == trigger);
        }
    }


}
