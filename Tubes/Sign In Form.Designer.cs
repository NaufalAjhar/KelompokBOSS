namespace Tubes
{
    partial class Sign_In_Form
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
            this.SignInButton.Location = new System.Drawing.Point(286, 208);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(75, 23);
            this.SignInButton.TabIndex = 15;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // InputPasswordLabel
            // 
            this.InputPasswordLabel.AutoSize = true;
            this.InputPasswordLabel.Location = new System.Drawing.Point(283, 153);
            this.InputPasswordLabel.Name = "InputPasswordLabel";
            this.InputPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.InputPasswordLabel.TabIndex = 14;
            this.InputPasswordLabel.Text = "Password";
            // 
            // InputEmailLabel
            // 
            this.InputEmailLabel.AutoSize = true;
            this.InputEmailLabel.Location = new System.Drawing.Point(283, 104);
            this.InputEmailLabel.Name = "InputEmailLabel";
            this.InputEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.InputEmailLabel.TabIndex = 13;
            this.InputEmailLabel.Text = "Email";
            // 
            // InputPasswordText
            // 
            this.InputPasswordText.Location = new System.Drawing.Point(286, 166);
            this.InputPasswordText.Name = "InputPasswordText";
            this.InputPasswordText.Size = new System.Drawing.Size(150, 20);
            this.InputPasswordText.TabIndex = 12;
            this.InputPasswordText.UseSystemPasswordChar = true;
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Location = new System.Drawing.Point(331, 74);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(47, 13);
            this.SignInLabel.TabIndex = 11;
            this.SignInLabel.Text = "SIGN IN";
            this.SignInLabel.Click += new System.EventHandler(this.SignInLabel_Click);
            // 
            // InputEmailText
            // 
            this.InputEmailText.Location = new System.Drawing.Point(286, 120);
            this.InputEmailText.Name = "InputEmailText";
            this.InputEmailText.Size = new System.Drawing.Size(150, 20);
            this.InputEmailText.TabIndex = 10;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(361, 208);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 9;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // Sign_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.InputPasswordLabel);
            this.Controls.Add(this.InputEmailLabel);
            this.Controls.Add(this.InputPasswordText);
            this.Controls.Add(this.SignInLabel);
            this.Controls.Add(this.InputEmailText);
            this.Controls.Add(this.SignUpButton);
            this.Name = "Sign_In_Form";
            this.Text = "Sign_In_Form";
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