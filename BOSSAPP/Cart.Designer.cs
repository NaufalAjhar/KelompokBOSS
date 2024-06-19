namespace BOSSAPP
{
    partial class CartForm
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
            this.listViewCart = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backButton = new System.Windows.Forms.Button();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.hapusButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCart
            // 
            this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Name,
            this.QTY,
            this.Price});
            this.listViewCart.FullRowSelect = true;
            this.listViewCart.HideSelection = false;
            this.listViewCart.Location = new System.Drawing.Point(32, 65);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(357, 341);
            this.listViewCart.TabIndex = 0;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.View = System.Windows.Forms.View.Details;
            this.listViewCart.SelectedIndexChanged += new System.EventHandler(this.listViewCart_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 121;
            // 
            // QTY
            // 
            this.QTY.Text = "QTY";
            this.QTY.Width = 116;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 104;
            // 
            // backButton
            // 
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(32, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(65, 42);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(405, 65);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(72, 16);
            this.labelTotalPrice.TabIndex = 12;
            this.labelTotalPrice.Text = "Total Price";
            this.labelTotalPrice.Click += new System.EventHandler(this.labelTotalPrice_Click);
            // 
            // hapusButton
            // 
            this.hapusButton.Location = new System.Drawing.Point(304, 412);
            this.hapusButton.Name = "hapusButton";
            this.hapusButton.Size = new System.Drawing.Size(85, 26);
            this.hapusButton.TabIndex = 13;
            this.hapusButton.Text = "Delete";
            this.hapusButton.UseVisualStyleBackColor = true;
            this.hapusButton.Click += new System.EventHandler(this.hapusButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(408, 118);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(99, 33);
            this.checkoutButton.TabIndex = 14;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.hapusButton);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.listViewCart);
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader QTY;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button hapusButton;
        private System.Windows.Forms.Button checkoutButton;
    }
}