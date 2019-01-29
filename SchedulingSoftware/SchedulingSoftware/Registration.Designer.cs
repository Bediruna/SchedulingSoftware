namespace SchedulingSoftware
{
    partial class Registration
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
            this.registerGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.confirmPassTextBox = new System.Windows.Forms.TextBox();
            this.confirmPassLabel = new System.Windows.Forms.Label();
            this.mismatchLabel = new System.Windows.Forms.Label();
            this.enterInfolabel = new System.Windows.Forms.Label();
            this.registerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerGroupBox
            // 
            this.registerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerGroupBox.Controls.Add(this.enterInfolabel);
            this.registerGroupBox.Controls.Add(this.mismatchLabel);
            this.registerGroupBox.Controls.Add(this.confirmPassTextBox);
            this.registerGroupBox.Controls.Add(this.confirmPassLabel);
            this.registerGroupBox.Controls.Add(this.passwordTextbox);
            this.registerGroupBox.Controls.Add(this.usernameTextbox);
            this.registerGroupBox.Controls.Add(this.exitButton);
            this.registerGroupBox.Controls.Add(this.registerButton);
            this.registerGroupBox.Controls.Add(this.passwordLabel);
            this.registerGroupBox.Controls.Add(this.usernameLabel);
            this.registerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.registerGroupBox.Name = "registerGroupBox";
            this.registerGroupBox.Size = new System.Drawing.Size(310, 257);
            this.registerGroupBox.TabIndex = 1;
            this.registerGroupBox.TabStop = false;
            this.registerGroupBox.Text = "Register user";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(102, 90);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(150, 20);
            this.passwordTextbox.TabIndex = 7;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(102, 40);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(150, 20);
            this.usernameTextbox.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(224, 221);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 30);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(172, 175);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(80, 30);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(38, 93);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(36, 43);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.Location = new System.Drawing.Point(102, 130);
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.PasswordChar = '*';
            this.confirmPassTextBox.Size = new System.Drawing.Size(150, 20);
            this.confirmPassTextBox.TabIndex = 9;
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.AutoSize = true;
            this.confirmPassLabel.Location = new System.Drawing.Point(6, 133);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(91, 13);
            this.confirmPassLabel.TabIndex = 8;
            this.confirmPassLabel.Text = "Confirm Password";
            // 
            // mismatchLabel
            // 
            this.mismatchLabel.AutoSize = true;
            this.mismatchLabel.ForeColor = System.Drawing.Color.Red;
            this.mismatchLabel.Location = new System.Drawing.Point(99, 153);
            this.mismatchLabel.Name = "mismatchLabel";
            this.mismatchLabel.Size = new System.Drawing.Size(113, 13);
            this.mismatchLabel.TabIndex = 10;
            this.mismatchLabel.Text = "Password must match.";
            this.mismatchLabel.Visible = false;
            // 
            // enterInfolabel
            // 
            this.enterInfolabel.AutoSize = true;
            this.enterInfolabel.ForeColor = System.Drawing.Color.Red;
            this.enterInfolabel.Location = new System.Drawing.Point(78, 24);
            this.enterInfolabel.Name = "enterInfolabel";
            this.enterInfolabel.Size = new System.Drawing.Size(196, 13);
            this.enterInfolabel.TabIndex = 11;
            this.enterInfolabel.Text = "Please enter a username and password.";
            this.enterInfolabel.Visible = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 281);
            this.Controls.Add(this.registerGroupBox);
            this.Name = "Registration";
            this.Text = "Registration";
            this.registerGroupBox.ResumeLayout(false);
            this.registerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registerGroupBox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox confirmPassTextBox;
        private System.Windows.Forms.Label confirmPassLabel;
        private System.Windows.Forms.Label mismatchLabel;
        private System.Windows.Forms.Label enterInfolabel;
    }
}