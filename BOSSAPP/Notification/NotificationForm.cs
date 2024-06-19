using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BOSSAPP.Notification
{
    public partial class NotificationForm : Form
    {
        private List<Notification> notifications;
        private string notificationsFilePath = @"D:\1.Programming\BOSSAPP\BOSSAPP\Notification\notificationJson.json";

        public NotificationForm()
        {
            InitializeComponent();
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            LoadNotificationsFromJson();
        }

        private void LoadNotificationsFromJson()
        {
            try
            {
                if (File.Exists(notificationsFilePath))
                {
                    string jsonData = File.ReadAllText(notificationsFilePath);
                    notifications = JsonConvert.DeserializeObject<List<Notification>>(jsonData);

                    // add notification into list box
                    if (notifications != null)
                    {
                        foreach (var notification in notifications)
                        {
                            listBoxNotifications.Items.Add($"{notification.Title}: {notification.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Notification JSON file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notifications: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
