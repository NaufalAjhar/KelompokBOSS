using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using BOSSAPP.LoginSignIn;
using static BOSSAPP.LoginSignIn.SignInForm;
using itemList;
using System.Collections.Generic;

namespace BOSSAPP.Payment
{
    public partial class PaymentForm : Form
    {
        private int totalPrice;
        private User loggedInUser;
        private static readonly HttpClient client = new HttpClient();

        public PaymentForm(User user, int totalPrice)
        {
            this.totalPrice = totalPrice;
            loggedInUser = user;

            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            totalPriceLabel.Text = $"Total Price: {totalPrice}";
        }

        private async void PayButton_Click(object sender, EventArgs e)
        {
            var adminFee = 2500;

            var payment = new Payment(
                new Random().Next(1, 1000),   
                loggedInUser.id,             
                loggedInUser.Username,       
                "qris",                       
                totalPrice,                   
                adminFee                      
            );

            var jsonPayment = JsonConvert.SerializeObject(payment);
            var content = new StringContent(jsonPayment, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync("http://localhost:5139/api/payment", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //SAVE PURCHASED ITEMS
                    string jsonFilePath = @"D:\1.Programming\BOSSAPP\CartAPI\Data\itemCart.json";
                    string jsonData = File.ReadAllText(jsonFilePath);

        
                    List<cartItem> cartItems = JsonConvert.DeserializeObject<List<cartItem>>(jsonData);

                    int targetUserId = loggedInUser.id;

                    List<purchasedItem> purchasedItems = new List<purchasedItem>();
                    foreach (var item in cartItems)
                    {
                        if (item.UserId == targetUserId)
                        {
                            purchasedItems.Add(new purchasedItem
                            {
                                Id = item.itemId,
                                Name = item.Name,
                                qty = item.qty,
                                Price = item.Price,
                                UserId = item.UserId 
                            });
                        }
                    }


                    string jsonPurchasedItems = JsonConvert.SerializeObject(purchasedItems, Formatting.Indented);

                    string purchasedItemsPath = "D:\\1.Programming\\BOSSAPP\\BOSSAPP\\purchasedItem.json";
                    File.WriteAllText(purchasedItemsPath, jsonPurchasedItems);

                    //delete the cart
                    var deleteResponse = await client.DeleteAsync($"http://localhost:5230/api/itemCart/{loggedInUser.id}");
        
                    Form cartForm = new CartForm(loggedInUser);
                    cartForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Payment failed. Status code: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing the payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            Form cartForm = new CartForm(loggedInUser);
            cartForm.Show();
            this.Hide();
        }
    }
}
