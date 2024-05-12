using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notif
{
    public class NotificationConfig
    {
        public string Type { get; set; }
        public string Recipient { get; set; }
        public string Message { get; set; }
    }

    // Kelas untuk membaca konfigurasi notifikasi dari file atau database
    public class NotificationConfigurationReader
    {
        public List<NotificationConfig> ReadConfiguration()
        {
            // Contoh implementasi, seharusnya membaca dari sumber data yang sesungguhnya
            return new List<NotificationConfig>
        {
            new NotificationConfig { Type = "Email", Recipient = "example@example.com", Message = "This is an email notification" },
            new NotificationConfig { Type = "SMS", Recipient = "1234567890", Message = "This is an SMS notification" }
        };
        }
    }

    // Kelas untuk mengirim notifikasi berdasarkan konfigurasi
    public class NotificationSender
    {
        private List<NotificationConfig> _notificationConfigs;

        public NotificationSender(List<NotificationConfig> notificationConfigs)
        {
            _notificationConfigs = notificationConfigs;
        }

        public void SendNotification(string type)
        {
            foreach (var config in _notificationConfigs)
            {
                if (config.Type == type)
                {
                    // Mengirim notifikasi sesuai konfigurasi
                    Console.WriteLine($"Sending {config.Type} notification to {config.Recipient}: {config.Message}");
                    // Implementasi pengiriman notifikasi sesuai dengan jenisnya (contoh: email, SMS, dll.)
                    break;
                }
            }
        }
    }
}
