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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.backButton = new System.Windows.Forms.Button();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CounterQTY = new System.Windows.Forms.NumericUpDown();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CounterQTY)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.QTY,
            this.Price});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(357, 341);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(32, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(42, 42);
            this.backButton.TabIndex = 9;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 10;
            // 
            // CounterQTY
            // 
            this.CounterQTY.Location = new System.Drawing.Point(422, 122);
            this.CounterQTY.Name = "CounterQTY";
            this.CounterQTY.Size = new System.Drawing.Size(41, 22);
            this.CounterQTY.TabIndex = 12;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(579, 128);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(72, 16);
            this.TotalPriceLabel.TabIndex = 11;
            this.TotalPriceLabel.Text = "Total Price";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CounterQTY);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.listView1);
           
            this.Text = "CartForm";
            ((System.ComponentModel.ISupportInitialize)(this.CounterQTY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader QTY;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown CounterQTY;
        private System.Windows.Forms.Label TotalPriceLabel;
    }
}