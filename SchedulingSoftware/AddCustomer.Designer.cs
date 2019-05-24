namespace SchedulingSoftware
{
    partial class AddCustomer
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.phNumberLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.custGroupBox = new System.Windows.Forms.GroupBox();
            this.fillFieldsLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.custGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(60, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // phNumberLabel
            // 
            this.phNumberLabel.AutoSize = true;
            this.phNumberLabel.Location = new System.Drawing.Point(17, 90);
            this.phNumberLabel.Name = "phNumberLabel";
            this.phNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phNumberLabel.TabIndex = 1;
            this.phNumberLabel.Text = "Phone Number";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(50, 130);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address";
            // 
            // custGroupBox
            // 
            this.custGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custGroupBox.Controls.Add(this.fillFieldsLabel);
            this.custGroupBox.Controls.Add(this.cancelButton);
            this.custGroupBox.Controls.Add(this.saveButton);
            this.custGroupBox.Controls.Add(this.countryTextBox);
            this.custGroupBox.Controls.Add(this.countryLabel);
            this.custGroupBox.Controls.Add(this.postalCodeTextBox);
            this.custGroupBox.Controls.Add(this.cityTextBox);
            this.custGroupBox.Controls.Add(this.address2TextBox);
            this.custGroupBox.Controls.Add(this.postalCodeLabel);
            this.custGroupBox.Controls.Add(this.cityLabel);
            this.custGroupBox.Controls.Add(this.address2Label);
            this.custGroupBox.Controls.Add(this.addressTextBox);
            this.custGroupBox.Controls.Add(this.phNumberTextBox);
            this.custGroupBox.Controls.Add(this.nameTextBox);
            this.custGroupBox.Controls.Add(this.phNumberLabel);
            this.custGroupBox.Controls.Add(this.nameLabel);
            this.custGroupBox.Controls.Add(this.addressLabel);
            this.custGroupBox.Location = new System.Drawing.Point(12, 12);
            this.custGroupBox.Name = "custGroupBox";
            this.custGroupBox.Size = new System.Drawing.Size(250, 357);
            this.custGroupBox.TabIndex = 4;
            this.custGroupBox.TabStop = false;
            this.custGroupBox.Text = "New Customer";
            // 
            // fillFieldsLabel
            // 
            this.fillFieldsLabel.AutoSize = true;
            this.fillFieldsLabel.ForeColor = System.Drawing.Color.Red;
            this.fillFieldsLabel.Location = new System.Drawing.Point(107, 31);
            this.fillFieldsLabel.Name = "fillFieldsLabel";
            this.fillFieldsLabel.Size = new System.Drawing.Size(94, 13);
            this.fillFieldsLabel.TabIndex = 17;
            this.fillFieldsLabel.Text = "Please fill all fields.";
            this.fillFieldsLabel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(6, 321);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 30);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(164, 321);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 30);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(101, 282);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 14;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(52, 285);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 13;
            this.countryLabel.Text = "Country";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(101, 247);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTextBox.TabIndex = 12;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(101, 207);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 11;
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(101, 167);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(100, 20);
            this.address2TextBox.TabIndex = 10;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(31, 250);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.postalCodeLabel.TabIndex = 9;
            this.postalCodeLabel.Text = "Postal Code";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(71, 210);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "City";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(41, 170);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(54, 13);
            this.address2Label.TabIndex = 7;
            this.address2Label.Text = "Address 2";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(101, 127);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // phNumberTextBox
            // 
            this.phNumberTextBox.Location = new System.Drawing.Point(101, 87);
            this.phNumberTextBox.Name = "phNumberTextBox";
            this.phNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phNumberTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(101, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 381);
            this.Controls.Add(this.custGroupBox);
            this.Name = "AddCustomer";
            this.Text = "Add Customer";
            this.custGroupBox.ResumeLayout(false);
            this.custGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phNumberLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.GroupBox custGroupBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phNumberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label fillFieldsLabel;
    }
}