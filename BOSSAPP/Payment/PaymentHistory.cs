using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BOSSAPP.LoginSignIn;
using static BOSSAPP.LoginSignIn.SignInForm;
using BOSSAPP.Payment; 

namespace BOSSAPP.Payment
{
    public partial class PaymentHistory : Form
    {
        private PaymentController paymentController;
        private User loggedInUser; 

        public PaymentHistory(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            paymentController = new PaymentController();
        }

        private void PaymentHistory_Load(object sender, EventArgs e)
        {
            DisplayPaymentsByUser(loggedInUser.id);
        }

        private void DisplayPaymentsByUser(int userID)
        {
            List<Payment> userPayments = paymentController.GetPaymentByIDUser(userID);
           
            dataGridViewPayments.DataSource = userPayments;

            dataGridViewPayments.Columns.Remove("ID_Payment");
            dataGridViewPayments.Columns.Remove("ID_User");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form home = new Home(loggedInUser);
            home.Show();
            this.Hide();
        }
    }
}
