namespace BOSSAPP.UlasanProduct
{
    partial class ReviewForm
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
            this.dataGridViewReviews = new System.Windows.Forms.DataGridView();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.textReview = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReviews
            // 
            this.dataGridViewReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviews.Location = new System.Drawing.Point(91, 80);
            this.dataGridViewReviews.Name = "dataGridViewReviews";
            this.dataGridViewReviews.RowHeadersWidth = 51;
            this.dataGridViewReviews.RowTemplate.Height = 24;
            this.dataGridViewReviews.Size = new System.Drawing.Size(601, 301);
            this.dataGridViewReviews.TabIndex = 0;
            this.dataGridViewReviews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReviews_CellClick);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(352, 415);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 1;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(91, 35);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // textReview
            // 
            this.textReview.Location = new System.Drawing.Point(91, 387);
            this.textReview.Name = "textReview";
            this.textReview.Size = new System.Drawing.Size(601, 22);
            this.textReview.TabIndex = 3;
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textReview);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.dataGridViewReviews);
            this.Name = "ReviewForm";
            this.Text = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReviews;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox textReview;
    }
}