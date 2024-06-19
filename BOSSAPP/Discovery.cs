using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using itemList;
using Newtonsoft.Json;
using static BOSSAPP.LoginSignIn.SignInForm;
using BOSSAPP.UlasanProduct;
using BOSSAPP.Notification;
using System.Collections.Generic;

namespace BOSSAPP
{
    public partial class Discovery : Form
    {
        private string itemName;
        private int qty;
        private int itemPrice;
        private int itemId; 
        private DiscoveryFeature discoveryFeature;

        private User loggedInUser;

        private NotificationManager notificationManager;

        public Discovery(User user)
        {
            InitializeComponent();

            var configManager = new NotificationConfigManager("D:\\1.Programming\\BOSSAPP\\BOSSAPP\\Notification\\config.json");

            notificationManager = new NotificationManager(configManager);

            loggedInUser = user;

            CounterQTY.Value = 1;
            discoveryFeature = new DiscoveryFeature();

            var itemManager = new ItemManager(discoveryFeature, this);
            itemManager.AddItem();
        }

        public void AddItemToListView(Item item)
        {
            var listViewItem = new ListViewItem(item.Id.ToString());
            listViewItem.SubItems.Add(item.Name);
            listViewItem.SubItems.Add(item.Price.ToString());
            listView1.Items.Add(listViewItem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReviewButton.Enabled = true;
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    var selectedItem = listView1.SelectedItems[0];
                    itemId = int.Parse(selectedItem.Text); 
                    itemName = selectedItem.SubItems[1].Text;
                    itemPrice = int.Parse(selectedItem.SubItems[2].Text);

                    NameBox.Text = itemName;
                    TotalPriceLabel.Text = itemPrice.ToString();
                    CounterQTY.Value = 1;
                    qty = Convert.ToInt32(CounterQTY.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CounterQTY_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    var text = listView1.SelectedItems[0].SubItems[2].Text;
                    var totalPrice = int.Parse(text) * CounterQTY.Value;
                    TotalPriceLabel.Text = totalPrice.ToString();
                    qty = Convert.ToInt32(CounterQTY.Value);
                    itemPrice = Convert.ToInt32(totalPrice);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var home = new Home(loggedInUser);
            home.Show();
            this.Hide();
        }

        private async void AddToCartButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int randomId = random.Next();

            var item = new cartItem
            {
                Id = randomId,
                itemId = itemId,
                Name = itemName,
                qty = qty,
                Price = itemPrice,
                UserId = loggedInUser.id
            };

            if (string.IsNullOrEmpty(item.Name) || item.qty == 0)
            {
                MessageBox.Show("Error: quantity cannot be zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5230/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("api/itemCart", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Item added into Cart", "OK", MessageBoxButtons.OK);
                    //trigger notification
                    var parameters = new Dictionary<string, string>
                    {
                        { "itemName", item.Name } 
                    };
                    notificationManager.TriggerNotification("cartUpdate", parameters);
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: Could not add item to cart. {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void Discovery_Load(object sender, EventArgs e)
        {

        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            Form reivew = new ReviewProduct(itemId);
            reivew.ShowDialog();
        }
    }
}
