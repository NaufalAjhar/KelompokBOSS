namespace Tubes
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
            this.SuspendLayout();
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(317, 171);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 18;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(317, 122);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 17;
            this.UsernameLabel.Text = "Username";
            // 
            // InputPhoneText
            // 
            this.InputPhoneText.Location = new System.Drawing.Point(320, 184);
            this.InputPhoneText.Name = "InputPhoneText";
            this.InputPhoneText.Size = new System.Drawing.Size(150, 20);
            this.InputPhoneText.TabIndex = 16;
            this.InputPhoneText.UseSystemPasswordChar = true;
            // 
            // InputUsernameText
            // 
            this.InputUsernameText.Location = new System.Drawing.Point(320, 138);
            this.InputUsernameText.Name = "InputUsernameText";
            this.InputUsernameText.Size = new System.Drawing.Size(150, 20);
            this.InputUsernameText.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Email";
            // 
            // PasswordText
            // 
            this.PasswordText.Enabled = false;
            this.PasswordText.Location = new System.Drawing.Point(320, 278);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(104, 20);
            this.PasswordText.TabIndex = 20;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(320, 232);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(150, 20);
            this.EmailText.TabIndex = 19;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(320, 334);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(150, 23);
            this.LogOutButton.TabIndex = 23;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(430, 276);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(40, 23);
            this.EditButton.TabIndex = 24;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(320, 305);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(150, 23);
            this.SaveChangesButton.TabIndex = 25;
            this.SaveChangesButton.Text = "Save";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click_1);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Profile";
            this.Text = "Profile";
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
    }
}