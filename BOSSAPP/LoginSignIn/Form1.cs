﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static BOSSAPP.LoginSignIn.SignInForm;

namespace BOSSAPP.LoginSignIn
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void SignInButton_Click(object sender, EventArgs e)
        {
            var SignInForm = new SignInForm(null);
            SignInForm.Show();
            this.Hide();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            
            string Email = InputEmailText.Text;
            string password = InputPasswordText.Text;
            string confirmPassword = ConfirmPasswordText.Text;

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a Email and password.");
                return;
            }

            if (confirmPassword != password)
            {

                MessageBox.Show("Password Does Not Match");
                return;
            }

            try
            {
                string json = File.ReadAllText("D:\\1.Programming\\BOSSAPP\\BOSSAPP\\LoginSignIn\\user.json");
                var users = JsonConvert.DeserializeObject<User[]>(json);
             
                // Check if Email already exists & id already exist
                var rand = new Random();
            
                var id = rand.Next(100000,999999);
               

                foreach (var user in users)
                {
                    while (id == user.id)
                    {
                        id = rand.Next(100000, 99999);
                    }
                    if (user.Email == Email)
                    {
                        MessageBox.Show("Email already exists. Please choose a different one.");
                        return;
                    }
                }

                // Add new user
                Array.Resize(ref users, users.Length + 1);
                users[users.Length - 1] = new User { id = id, Email = Email, Password = password };

                // Save updated user list
                string updatedJson = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText("D:\\1.Programming\\BOSSAPP\\BOSSAPP\\LoginSignIn\\user.json", updatedJson);

                MessageBox.Show("Sign up successful!");

                var SignInForm = new SignInForm(null);
                SignInForm.Show();
                this.Hide();
            } catch (Exception ex)
            {
                Console.WriteLine("oops");
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
