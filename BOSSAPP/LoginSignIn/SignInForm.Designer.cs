namespace BOSSAPP.LoginSignIn
{
    partial class SignInForm
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
            this.SignInButton = new System.Windows.Forms.Button();
            this.InputPasswordLabel = new System.Windows.Forms.Label();
            this.InputEmailLabel = new System.Windows.Forms.Label();
            this.InputPasswordText = new System.Windows.Forms.TextBox();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.InputEmailText = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(286, 305);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(4);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(100, 28);
            this.SignInButton.TabIndex = 22;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // InputPasswordLabel
            // 
            this.InputPasswordLabel.AutoSize = true;
            this.InputPasswordLabel.Location = new System.Drawing.Point(282, 237);
            this.InputPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputPasswordLabel.Name = "InputPasswordLabel";
            this.InputPasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.InputPasswordLabel.TabIndex = 21;
            this.InputPasswordLabel.Text = "Password";
            // 
            // InputEmailLabel
            // 
            this.InputEmailLabel.AutoSize = true;
            this.InputEmailLabel.Location = new System.Drawing.Point(282, 177);
            this.InputEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputEmailLabel.Name = "InputEmailLabel";
            this.InputEmailLabel.Size = new System.Drawing.Size(41, 16);
            this.InputEmailLabel.TabIndex = 20;
            this.InputEmailLabel.Text = "Email";
            // 
            // InputPasswordText
            // 
            this.InputPasswordText.Location = new System.Drawing.Point(286, 253);
            this.InputPasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.InputPasswordText.Name = "InputPasswordText";
            this.InputPasswordText.Size = new System.Drawing.Size(199, 22);
            this.InputPasswordText.TabIndex = 19;
            this.InputPasswordText.UseSystemPasswordChar = true;
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Location = new System.Drawing.Point(346, 140);
            this.SignInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(55, 16);
            this.SignInLabel.TabIndex = 18;
            this.SignInLabel.Text = "SIGN IN";
            // 
            // InputEmailText
            // 
            this.InputEmailText.Location = new System.Drawing.Point(286, 197);
            this.InputEmailText.Margin = new System.Windows.Forms.Padding(4);
            this.InputEmailText.Name = "InputEmailText";
            this.InputEmailText.Size = new System.Drawing.Size(199, 22);
            this.InputEmailText.TabIndex = 17;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(386, 305);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(100, 28);
            this.SignUpButton.TabIndex = 16;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignInForm
            // 
            this.ClientSize = new System.Drawing.Size(777, 496);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.InputPasswordLabel);
            this.Controls.Add(this.InputEmailLabel);
            this.Controls.Add(this.InputPasswordText);
            this.Controls.Add(this.SignInLabel);
            this.Controls.Add(this.InputEmailText);
            this.Controls.Add(this.SignUpButton);
            this.Name = "SignInForm";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label InputPasswordLabel;
        private System.Windows.Forms.Label InputEmailLabel;
        private System.Windows.Forms.TextBox InputPasswordText;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.TextBox InputEmailText;
        private System.Windows.Forms.Button SignUpButton;
    }
}