namespace BOSSAPP.LoginSignIn
{
    partial class Profile
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
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.InputPhoneText = new System.Windows.Forms.TextBox();
            this.InputUsernameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(423, 210);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(97, 16);
            this.PhoneNumberLabel.TabIndex = 18;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(423, 150);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(70, 16);
            this.UsernameLabel.TabIndex = 17;
            this.UsernameLabel.Text = "Username";
            // 
            // InputPhoneText
            // 
            this.InputPhoneText.Location = new System.Drawing.Point(427, 226);
            this.InputPhoneText.Margin = new System.Windows.Forms.Padding(4);
            this.InputPhoneText.Name = "InputPhoneText";
            this.InputPhoneText.Size = new System.Drawing.Size(199, 22);
            this.InputPhoneText.TabIndex = 16;
            // 
            // InputUsernameText
            // 
            this.InputUsernameText.Location = new System.Drawing.Point(427, 170);
            this.InputUsernameText.Margin = new System.Windows.Forms.Padding(4);
            this.InputUsernameText.Name = "InputUsernameText";
            this.InputUsernameText.Size = new System.Drawing.Size(199, 22);
            this.InputUsernameText.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Email";
            // 
            // PasswordText
            // 
            this.PasswordText.Enabled = false;
            this.PasswordText.Location = new System.Drawing.Point(427, 342);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(137, 22);
            this.PasswordText.TabIndex = 20;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(427, 286);
            this.EmailText.Margin = new System.Windows.Forms.Padding(4);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(199, 22);
            this.EmailText.TabIndex = 19;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(427, 411);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(200, 28);
            this.LogOutButton.TabIndex = 23;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(573, 340);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(53, 28);
            this.EditButton.TabIndex = 24;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(427, 375);
            this.SaveChangesButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(200, 28);
            this.SaveChangesButton.TabIndex = 25;
            this.SaveChangesButton.Text = "Save";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click_1);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(13, 513);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(119, 28);
            this.Back.TabIndex = 26;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.InputPhoneText);
            this.Controls.Add(this.InputUsernameText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox InputPhoneText;
        private System.Windows.Forms.TextBox InputUsernameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button Back;
    }
}