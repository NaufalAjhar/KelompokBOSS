using Notif;

class Program
{
    static void Main(string[] args)
    {
        // Membaca konfigurasi notifikasi
        var configReader = new NotificationConfigurationReader();
        var notificationConfigs = configReader.ReadConfiguration();

        // Membuat objek sender dengan konfigurasi notifikasi
        var notificationSender = new NotificationSender(notificationConfigs);

        // Mengirim notifikasi
        notificationSender.SendNotification("Email");
        notificationSender.SendNotification("SMS");
    }
}