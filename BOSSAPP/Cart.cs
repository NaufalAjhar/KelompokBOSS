using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using itemList;
using Newtonsoft.Json;
using static BOSSAPP.LoginSignIn.SignInForm;
using BOSSAPP.Payment;

namespace BOSSAPP
{
    public partial class CartForm : Form
    {
        private string itemName;
        private int qty;
        private int itemPrice;
        private int itemId;

        int totalPrice = 0;

        private HttpClient client;
        private string apiBaseUrl = "http://localhost:5230/api/itemCart"; 
        private CartManager cartManager;

        private User loggedInUser;
        public CartForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            client = new HttpClient();
            cartManager = new CartManager();

            FetchItemsAndUpdateListView();
            CalculateAndSetTotalPrice();
        }

        private async Task FetchItemsAndUpdateListView()
        {
            string apiUrl = $"{apiBaseUrl}?userId={loggedInUser.id}";

            try
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    List<cartItem> items = JsonConvert.DeserializeObject<List<cartItem>>(jsonResponse);

                    listViewCart.Items.Clear();
                    cartManager.Clear();

                    foreach (var item in items)
                    {
                        cartManager.AddToCart(item, loggedInUser.id); 
                        AddItemToListView(item); 
                    }

                    CalculateAndSetTotalPrice(); 
                }
                else
                {
                    MessageBox.Show($"Failed to retrieve items from API. Status code: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching items from API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddItemToListView(cartItem item)
        {
            var listViewItem = new ListViewItem(item.Id.ToString());
            listViewItem.SubItems.Add(item.Name);
            listViewItem.SubItems.Add(item.qty.ToString());
            listViewItem.SubItems.Add(item.Price.ToString());
            listViewCart.Items.Add(listViewItem);
        }

        private void CalculateAndSetTotalPrice()
        {
            totalPrice = 0;
            
            foreach (var item in cartManager.GetItems())
            {
                totalPrice += item.Price;
            }
            labelTotalPrice.Text = $"Total Price: {totalPrice}"; 
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var Home = new Home(loggedInUser);
            Home.Show();
            this.Hide();
        }

        private void listViewCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewCart.SelectedItems.Count > 0)
                {
                    var selectedItem = listViewCart.SelectedItems[0];
                    itemId = int.Parse(selectedItem.Text);
                    itemName = selectedItem.SubItems[1].Text;
                    qty = int.Parse(selectedItem.SubItems[2].Text);
                    itemPrice = int.Parse(selectedItem.SubItems[3].Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void hapusButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync($"{apiBaseUrl}/{loggedInUser.id}/{itemId}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    await FetchItemsAndUpdateListView();
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to delete item. Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CartForm_Load(object sender, EventArgs e)
        {

        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            Form payment = new PaymentForm(loggedInUser,totalPrice);
            payment.Show();
            this.Hide();
        }
    }
}
