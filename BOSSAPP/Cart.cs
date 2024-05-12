using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using itemList;

namespace BOSSAPP
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
            UpdateListView();
        }

        public void AddItemToListView(cartItem item)
        {
            var listViewItem = new ListViewItem(item.Name);
            listViewItem.SubItems.Add(item.Price.ToString());
            listViewItem.SubItems.Add(item.qty.ToString());
            listView1.Items.Add(listViewItem);
        }

        public void UpdateListView()
        {
          //
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            var Home = new Home();
            Home.Show();
            this.Hide();
        }
    }
}
