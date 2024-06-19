namespace BOSSAPP.LoginSignIn
{
    partial class SignUpForm
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
            this.SignUpButton = new System.Windows.Forms.Button();
            this.InputEmailText = new System.Windows.Forms.TextBox();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.InputPasswordText = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordText = new System.Windows.Forms.TextBox();
            this.InputEmailLabel = new System.Windows.Forms.Label();
            this.InputPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(381, 292);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(100, 28);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // InputEmailText
            // 
            this.InputEmailText.Location = new System.Drawing.Point(381, 121);
            this.InputEmailText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputEmailText.Name = "InputEmailText";
            this.InputEmailText.Size = new System.Drawing.Size(199, 22);
            this.InputEmailText.TabIndex = 1;
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Location = new System.Drawing.Point(441, 64);
            this.SignUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(61, 16);
            this.SignUpLabel.TabIndex = 2;
            this.SignUpLabel.Text = "SIGN UP";
            this.SignUpLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputPasswordText
            // 
            this.InputPasswordText.Location = new System.Drawing.Point(381, 177);
            this.InputPasswordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputPasswordText.Name = "InputPasswordText";
            this.InputPasswordText.Size = new System.Drawing.Size(199, 22);
            this.InputPasswordText.TabIndex = 3;
            this.InputPasswordText.UseSystemPasswordChar = true;
            // 
            // ConfirmPasswordText
            // 
            this.ConfirmPasswordText.Location = new System.Drawing.Point(381, 238);
            this.ConfirmPasswordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmPasswordText.Name = "ConfirmPasswordText";
            this.ConfirmPasswordText.Size = new System.Drawing.Size(199, 22);
            this.ConfirmPasswordText.TabIndex = 4;
            this.ConfirmPasswordText.UseSystemPasswordChar = true;
            // 
            // InputEmailLabel
            // 
            this.InputEmailLabel.AutoSize = true;
            this.InputEmailLabel.Location = new System.Drawing.Point(377, 101);
            this.InputEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputEmailLabel.Name = "InputEmailLabel";
            this.InputEmailLabel.Size = new System.Drawing.Size(41, 16);
            this.InputEmailLabel.TabIndex = 5;
            this.InputEmailLabel.Text = "Email";
            // 
            // InputPasswordLabel
            // 
            this.InputPasswordLabel.AutoSize = true;
            this.InputPasswordLabel.Location = new System.Drawing.Point(377, 161);
            this.InputPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputPasswordLabel.Name = "InputPasswordLabel";
            this.InputPasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.InputPasswordLabel.TabIndex = 6;
            this.InputPasswordLabel.Text = "Password";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(377, 218);
            this.ConfirmPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(115, 16);
            this.ConfirmPasswordLabel.TabIndex = 7;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(481, 292);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(100, 28);
            this.SignInButton.TabIndex = 8;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.InputPasswordLabel);
            this.Controls.Add(this.InputEmailLabel);
            this.Controls.Add(this.ConfirmPasswordText);
            this.Controls.Add(this.InputPasswordText);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.InputEmailText);
            this.Controls.Add(this.SignUpButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignUpForm";
            this.Text = "Sign Up ";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox InputEmailText;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.TextBox InputPasswordText;
        private System.Windows.Forms.TextBox ConfirmPasswordText;
        private System.Windows.Forms.Label InputEmailLabel;
        private System.Windows.Forms.Label InputPasswordLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Button SignInButton;
    }
}

