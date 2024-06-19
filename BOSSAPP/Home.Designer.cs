namespace BOSSAPP
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label2 = new System.Windows.Forms.Label();
            this.DiscoveryButton = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.ReviewBtn = new System.Windows.Forms.Button();
            this.NotificationButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hello,";
            // 
            // DiscoveryButton
            // 
            this.DiscoveryButton.Location = new System.Drawing.Point(12, 159);
            this.DiscoveryButton.Name = "DiscoveryButton";
            this.DiscoveryButton.Size = new System.Drawing.Size(117, 73);
            this.DiscoveryButton.TabIndex = 3;
            this.DiscoveryButton.Text = "Discovery";
            this.DiscoveryButton.UseVisualStyleBackColor = true;
            this.DiscoveryButton.Click += new System.EventHandler(this.DiscoveryButton_Click);
            // 
            // CartButton
            // 
            this.CartButton.Location = new System.Drawing.Point(12, 263);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(117, 73);
            this.CartButton.TabIndex = 4;
            this.CartButton.Text = "Cart";
            this.CartButton.UseVisualStyleBackColor = true;
            this.CartButton.Click += new System.EventHandler(this.CartButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Location = new System.Drawing.Point(562, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(72, 30);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Logout";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(198, 159);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(117, 73);
            this.historyButton.TabIndex = 7;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // ReviewBtn
            // 
            this.ReviewBtn.Location = new System.Drawing.Point(198, 263);
            this.ReviewBtn.Name = "ReviewBtn";
            this.ReviewBtn.Size = new System.Drawing.Size(117, 73);
            this.ReviewBtn.TabIndex = 8;
            this.ReviewBtn.Text = "Review";
            this.ReviewBtn.UseVisualStyleBackColor = true;
            this.ReviewBtn.Click += new System.EventHandler(this.ReviewBtn_Click);
            // 
            // NotificationButton
            // 
            this.NotificationButton.Location = new System.Drawing.Point(12, 33);
            this.NotificationButton.Name = "NotificationButton";
            this.NotificationButton.Size = new System.Drawing.Size(117, 60);
            this.NotificationButton.TabIndex = 9;
            this.NotificationButton.Text = "Notification";
            this.NotificationButton.UseVisualStyleBackColor = true;
            this.NotificationButton.Click += new System.EventHandler(this.NotificationButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileButton.BackgroundImage")));
            this.ProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileButton.Location = new System.Drawing.Point(562, 33);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(72, 72);
            this.ProfileButton.TabIndex = 1;
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.NotificationButton);
            this.Controls.Add(this.ReviewBtn);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CartButton);
            this.Controls.Add(this.DiscoveryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProfileButton);
            this.Name = "Home";
            this.Text = "Build Our Space Store";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DiscoveryButton;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button ReviewBtn;
        private System.Windows.Forms.Button NotificationButton;
    }
}