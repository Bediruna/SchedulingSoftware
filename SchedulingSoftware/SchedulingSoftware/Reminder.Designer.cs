namespace SchedulingSoftware
{
    partial class Reminder
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
            this.closeButton = new System.Windows.Forms.Button();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.headMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeButton.Location = new System.Drawing.Point(298, 1033);
            this.closeButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(253, 85);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            this.endDateTimePicker.Enabled = false;
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(263, 854);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(397, 44);
            this.endDateTimePicker.TabIndex = 38;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            this.startDateTimePicker.Enabled = false;
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(263, 766);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(397, 44);
            this.startDateTimePicker.TabIndex = 37;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Enabled = false;
            this.typeTextBox.Location = new System.Drawing.Point(263, 598);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(397, 44);
            this.typeTextBox.TabIndex = 35;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Enabled = false;
            this.contactTextBox.Location = new System.Drawing.Point(263, 512);
            this.contactTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(397, 44);
            this.contactTextBox.TabIndex = 34;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Enabled = false;
            this.locationTextBox.Location = new System.Drawing.Point(263, 427);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(397, 44);
            this.locationTextBox.TabIndex = 33;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(263, 199);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(397, 192);
            this.descriptionTextBox.TabIndex = 32;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Enabled = false;
            this.titleTextBox.Location = new System.Drawing.Point(263, 114);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(397, 44);
            this.titleTextBox.TabIndex = 31;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(158, 871);
            this.endLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(74, 37);
            this.endLabel.TabIndex = 30;
            this.endLabel.Text = "End";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(149, 783);
            this.startLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(85, 37);
            this.startLabel.TabIndex = 29;
            this.startLabel.Text = "Start";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(143, 606);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(87, 37);
            this.typeLabel.TabIndex = 27;
            this.typeLabel.Text = "Type";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(101, 521);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(128, 37);
            this.contactLabel.TabIndex = 26;
            this.contactLabel.Text = "Contact";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(89, 435);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(139, 37);
            this.locationLabel.TabIndex = 25;
            this.locationLabel.Text = "Location";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(51, 208);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(177, 37);
            this.descriptionLabel.TabIndex = 24;
            this.descriptionLabel.Text = "Description";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(155, 122);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(77, 37);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "Title";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(149, 692);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(80, 37);
            this.urlLabel.TabIndex = 28;
            this.urlLabel.Text = "URL";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Enabled = false;
            this.urlTextBox.Location = new System.Drawing.Point(263, 683);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(397, 44);
            this.urlTextBox.TabIndex = 36;
            // 
            // headMsg
            // 
            this.headMsg.AutoSize = true;
            this.headMsg.Location = new System.Drawing.Point(38, 26);
            this.headMsg.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.headMsg.Name = "headMsg";
            this.headMsg.Size = new System.Drawing.Size(536, 37);
            this.headMsg.TabIndex = 39;
            this.headMsg.Text = "You have an upcoming appoint with ";
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 1153);
            this.Controls.Add(this.headMsg);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Reminder";
            this.Text = "Appointment Reminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label headMsg;
    }
}