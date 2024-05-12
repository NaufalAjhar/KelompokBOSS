using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOSSAPP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            Form cartForm = new CartForm();
            cartForm.Show();
            this.Hide();
        }

        private void DiscoveryButton_Click(object sender, EventArgs e)
        {
            Form Discovery = new Discovery();
            Discovery.Show();
            this.Hide();
        }
    }
}
