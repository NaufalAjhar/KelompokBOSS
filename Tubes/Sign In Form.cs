using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.LinkLabel;

namespace Tubes
{
    public partial class Sign_In_Form : Form
    {
        private List<User> users;
        public User loggedInUser;
        public Sign_In_Form(User loggedin)
        {
            InitializeComponent();
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
                string json = File.ReadAllText("D:\\Telkom University\\SEMESTER 4\\KONTRUKSI PERANGKAT LUNAK\\TUBES\\Tubes\\Tubes\\user.json");
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
                var profileForm = new Profile(loggedInUser);
                profileForm.Show();
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
    }
}
