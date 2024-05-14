using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Tubes.Sign_In_Form;

namespace Tubes
{
    public partial class Profile : Form
    {
        private List<User> users;
        private User loggedInUser;

        public Profile(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            InputUsernameText.Text = loggedInUser.Username;
            InputPhoneText.Text = loggedInUser.PhoneNumber;
            EmailText.Text = loggedInUser.Email;
            PasswordText.Text = loggedInUser.Password;
        }

        private void UpdateUserProfile()
        {
            // Load all user data
            string json = File.ReadAllText("D:\\Telkom University\\SEMESTER 4\\KONTRUKSI PERANGKAT LUNAK\\TUBES\\Tubes\\Tubes\\user.json");
            users = JsonConvert.DeserializeObject<List<User>>(json);

            // Update the current user's profile
            User userToUpdate = users.FirstOrDefault(u => u.id == loggedInUser.id);
            if (userToUpdate != null)
            {
                userToUpdate.Username = InputUsernameText.Text;
                userToUpdate.PhoneNumber = InputPhoneText.Text;
                userToUpdate.Email = EmailText.Text;
                userToUpdate.Password = PasswordText.Text;
            }

            // Save all user data back to JSON file
            SaveData("D:\\Telkom University\\SEMESTER 4\\KONTRUKSI PERANGKAT LUNAK\\TUBES\\Tubes\\Tubes\\user.json", users);
        }

        private void SaveData<T>(string filePath, List<T> dataList)
        {
            try
            {
                string json = JsonConvert.SerializeObject(dataList, Formatting.Indented);
                File.WriteAllText(filePath, json);
                MessageBox.Show("User profile updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var signInForm = new Sign_In_Form(null);
            signInForm.Show();
            this.Hide();
        }

        private void SaveChangesButton_Click_1(object sender, EventArgs e)
        {
            UpdateUserProfile();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(PasswordText.Enabled == true)
            {
                PasswordText.Enabled = false;
            } else
            {
                PasswordText.Enabled = true;
            }
        }
    }
}
