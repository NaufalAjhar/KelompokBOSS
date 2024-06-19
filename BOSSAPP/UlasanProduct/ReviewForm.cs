using Newtonsoft.Json;
using ProductReview;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static BOSSAPP.LoginSignIn.SignInForm;

namespace BOSSAPP.UlasanProduct
{
    public partial class ReviewForm : Form
    {
        private List<purchasedItem> purchasedItems;
        private User loggedInUser;
        
        private int selectedProductId; 

        private string reviewsFilePath = @"D:\1.Programming\BOSSAPP\BOSSAPP\UlasanProduct\reviews.json";

        public ReviewForm(User user)
        {
            loggedInUser = user;
            InitializeComponent();
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            LoadPurchasedItems();
        }

        private void LoadPurchasedItems()
        {
            int userId = loggedInUser.id;
            purchasedItems = LoadPurchasedItemsFromJson(userId);

            dataGridViewReviews.DataSource = purchasedItems;
        }

        private List<purchasedItem> LoadPurchasedItemsFromJson(int userId)
        {
            string purchasedItemsPath = @"D:\1.Programming\BOSSAPP\BOSSAPP\purchasedItem.json";
            if (File.Exists(purchasedItemsPath))
            {
                string jsonData = File.ReadAllText(purchasedItemsPath);
                List<purchasedItem> items = JsonConvert.DeserializeObject<List<purchasedItem>>(jsonData);

                // Filter items by user ID
                return items.Where(item => item.UserId == userId).ToList();
            }
            else
            {
                MessageBox.Show("Purchased items file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<purchasedItem>();
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string reviewText = textReview.Text;

            if (string.IsNullOrWhiteSpace(reviewText))
            {
                MessageBox.Show("Please enter a review.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            //check if too short
            if (!ReviewAutomata.CheckReviewContent(reviewText))
            {
                MessageBox.Show("Review content is too short. Please enter at least 10 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product to review", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Analyze the sentiment of the review
            ProductReviewAnalyzer<string> analyzer = new ProductReviewAnalyzer<string>(reviewText);
            string sentiment = analyzer.AnalyzeSentiment();

            Review newReview = new Review
            {
                Username = loggedInUser.Username,
                ReviewContent = reviewText,
                ProductId = selectedProductId,
                ReviewSentiment = sentiment 
            };

            SaveReviewToJson(newReview);
        }

        private void SaveReviewToJson(Review review)
        {
            try
            {
                List<Review> reviews = new List<Review>();

                if (File.Exists(reviewsFilePath))
                {
                    string jsonData = File.ReadAllText(reviewsFilePath);
                    reviews = JsonConvert.DeserializeObject<List<Review>>(jsonData) ?? new List<Review>();
                }

                reviews.Add(review);

                // Save reviews back to reviews.json
                string updatedJson = JsonConvert.SerializeObject(reviews, Formatting.Indented);
                File.WriteAllText(reviewsFilePath, updatedJson);

                MessageBox.Show("Review saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form home = new Home(loggedInUser);
            home.Show();
            this.Hide();
        }

        private void dataGridViewReviews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewReviews.Rows[e.RowIndex];
                //get product id
                selectedProductId = Convert.ToInt32(row.Cells["Id"].Value);
                MessageBox.Show($"Selected Product Id: {selectedProductId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
