using BOSSAPP.Notification;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOSSAPP.Notification;

namespace BOSSAPP.LoginSignIn
{
    public partial class SignInForm : Form
    {
        private List<User> users;
        public User loggedInUser;

        private NotificationManager notificationManager;

        public SignInForm(User loggedin)
        {
            InitializeComponent();

            var configManager = new NotificationConfigManager("D:\\1.Programming\\BOSSAPP\\BOSSAPP\\Notification\\config.json");
         
            notificationManager = new NotificationManager(configManager);

            LoadUsers();
        }

        public class User
        {
            public int id { get; set; }
            public string Username { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }

        }

        private void SignInLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoadUsers()
        {
            try
            {
                string json = File.ReadAllText("D:\\1.Programming\\BOSSAPP\\BOSSAPP\\LoginSignIn\\user.json");
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File users.json not found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }

            if (users == null)
                users = new List<User>();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string Email = InputEmailText.Text;
            string password = InputPasswordText.Text;

            // Pemeriksaan apakah Email dan password sesuai dengan yang diharapkan
            if (users.Any(u => u.Email == Email && u.Password == password))
            {
                foreach (var user in users)
                {
                    if (user.Email == Email)
                    {
                        loggedInUser = user;
                    }
                }
                var homeForm = new Home(loggedInUser);
                
                var parameters = new Dictionary<string, string>
                {
                    { "username", loggedInUser.Username }
                };
                notificationManager.TriggerNotification("welcome", parameters);
                
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email atau password salah. Silakan coba lagi.");
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var signupForm = new SignUpForm();
            this.Hide();
            signupForm.Show();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
