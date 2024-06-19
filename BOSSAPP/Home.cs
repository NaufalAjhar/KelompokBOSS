using BOSSAPP.LoginSignIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOSSAPP.LoginSignIn;
using static BOSSAPP.LoginSignIn.SignInForm;
using BOSSAPP.Notification;
using BOSSAPP.Payment;
using BOSSAPP.UlasanProduct;

namespace BOSSAPP
{
    public partial class Home : Form
    {

        private User loggedInUser;
        

        public Home(User user)
        {
            InitializeComponent();
            loggedInUser = user;

            

            label2.Text = $"Welcome, {loggedInUser.Username}";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form Login = new SignInForm(null);
            Login.Show();
            this.Hide();
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            Form cartForm = new CartForm(loggedInUser);
            cartForm.Show();
            this.Hide();
        }

        private void DiscoveryButton_Click(object sender, EventArgs e)
        {
            Form Discovery = new Discovery(loggedInUser);
            Discovery.Show();
            this.Hide();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Form Profile = new Profile(loggedInUser);
            Profile.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            Form paymentHistory = new PaymentHistory(loggedInUser);
            paymentHistory.Show();
            this.Hide();
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {

        }

        private void ReviewBtn_Click(object sender, EventArgs e)
        {
            Form reviewForm = new ReviewForm(loggedInUser);
            reviewForm.Show();
            this.Hide();
        }

        private void NotificationButton_Click(object sender, EventArgs e)
        {
            Form notificationForm = new NotificationForm();
            notificationForm.Show();
        }
    }
}
