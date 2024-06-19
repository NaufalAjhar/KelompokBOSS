using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using static BOSSAPP.LoginSignIn.SignInForm;

namespace BOSSAPP.UlasanProduct
{
    public partial class ReviewProduct : Form
    {
        private int productId;

        public ReviewProduct(int productId)
        {
            InitializeComponent();
            this.productId = productId;

            LoadReviewsFromJson();
        }

        private void LoadReviewsFromJson()
        {
            string jsonFilePath = "D:\\1.Programming\\BOSSAPP\\BOSSAPP\\UlasanProduct\\reviews.json";
            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                List<Review> reviews = JsonConvert.DeserializeObject<List<Review>>(jsonData);

                // Filter reviews for the specific product
                var filteredReviews = reviews.Where(r => r.ProductId == productId).ToList();

                foreach (var review in filteredReviews)
                {
                    AddReview(review.Username, review.ReviewSentiment, review.ReviewContent);
                }
            }
            else
            {
                MessageBox.Show("Reviews JSON file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddReview(string username, string reviewSentiment, string reviewContent)
        {
            Panel panelReview = new Panel
            {
                BackColor = System.Drawing.SystemColors.ControlLight,
                AutoSize = true
            };

            Label lblUsername = new Label
            {
                Text = $"Username: {username}",
                AutoSize = true,
                Location = new System.Drawing.Point(10, 10)
            };
            panelReview.Controls.Add(lblUsername);

            Label lblReviewSentiment = new Label
            {
                Text = $"Review: {reviewSentiment}",
                AutoSize = true,
                Location = new System.Drawing.Point(10, lblUsername.Bottom + 5)
            };
            panelReview.Controls.Add(lblReviewSentiment);

            Label lblReviewContent = new Label
            {
                Text = $"Review Content: {reviewContent}",
                AutoSize = true,
                Location = new System.Drawing.Point(10, lblReviewSentiment.Bottom + 5)
            };
            panelReview.Controls.Add(lblReviewContent);

            flowLayoutPanelReviews.Controls.Add(panelReview);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void flowLayoutPanelReviews_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
