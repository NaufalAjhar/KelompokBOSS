namespace BOSSAPP.UlasanProduct
{
    partial class ReviewProduct
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
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanelReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanelReviews
            // 
            this.flowLayoutPanelReviews.AutoScroll = true;
            this.flowLayoutPanelReviews.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelReviews.Location = new System.Drawing.Point(68, 66);
            this.flowLayoutPanelReviews.Name = "flowLayoutPanelReviews";
            this.flowLayoutPanelReviews.Size = new System.Drawing.Size(633, 302);
            this.flowLayoutPanelReviews.TabIndex = 2;
            this.flowLayoutPanelReviews.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelReviews_Paint);
            // 
            // ReviewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelReviews);
            this.Controls.Add(this.button1);
            this.Name = "ReviewProduct";
            this.Text = "Review";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReviews;
    }
}