namespace BOSSAPP
{
    partial class Discovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discovery));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CounterQTY = new System.Windows.Forms.NumericUpDown();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CounterQTY)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.Price});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(358, 329);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 148;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 170;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(557, 147);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(72, 16);
            this.TotalPriceLabel.TabIndex = 2;
            this.TotalPriceLabel.Text = "Total Price";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(397, 87);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(232, 22);
            this.NameBox.TabIndex = 3;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(524, 216);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(105, 45);
            this.AddToCartButton.TabIndex = 5;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // CounterQTY
            // 
            this.CounterQTY.Location = new System.Drawing.Point(400, 141);
            this.CounterQTY.Name = "CounterQTY";
            this.CounterQTY.Size = new System.Drawing.Size(41, 22);
            this.CounterQTY.TabIndex = 7;
            this.CounterQTY.ValueChanged += new System.EventHandler(this.CounterQTY_ValueChanged);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(33, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(42, 42);
            this.backButton.TabIndex = 8;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Discovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.CounterQTY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.listView1);
            this.Name = "Discovery";
            this.Text = "Discovery";
            this.Load += new System.EventHandler(this.Discovery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CounterQTY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CounterQTY;
        private System.Windows.Forms.Button backButton;
    }
}