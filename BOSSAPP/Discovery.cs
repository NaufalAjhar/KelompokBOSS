using System;
using System.Windows.Forms;
using itemList;

namespace BOSSAPP
{
    public partial class Discovery : Form
    {
        private String itemName;
        private int qty;
        private int itemPrice;
        public Discovery()
        {
            InitializeComponent();
            CounterQTY.Value = 1;
            var discoveryFeature = new DiscoveryFeature();
          
            var itemManager = new ItemManager(discoveryFeature,this);
            itemManager.AddItem();
        }

        public void AddItemToListView(Item item)
        {
            var listViewItem = new ListViewItem(item.Name);
            listView1.Items.Add(listViewItem);
            listViewItem.SubItems.Add(item.Price.ToString());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NameBox.Text = listView1.SelectedItems[0].Text;
                TotalPriceLabel.Text = listView1.SelectedItems[0].SubItems[1].Text;
                CounterQTY.Value = 1;
                itemName = NameBox.Text;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void CounterQTY_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var Text = listView1.SelectedItems[0].SubItems[1].Text;
                var totalPrice = int.Parse(Text) * CounterQTY.Value;
                TotalPriceLabel.Text = totalPrice.ToString();
                qty = Convert.ToInt32(CounterQTY.Value);
                itemPrice = Convert.ToInt32(totalPrice);
            } catch (Exception ex)
            {
                
            }
        }

        private void Discovery_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            var cartManager = new CartManager();

            var item = new cartItem
            {
                Name = itemName,
                qty = qty,
                Price = itemPrice
            };

            cartManager.AddToCart(item);
            
        }
    }
}
