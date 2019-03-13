namespace SchedulingSoftware
{
    partial class AddAppointment
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.addApptGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimeErrorlabel = new System.Windows.Forms.Label();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.fillFieldsLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.addApptGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(130, 122);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(77, 37);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // addApptGroupBox
            // 
            this.addApptGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addApptGroupBox.Controls.Add(this.dateTimeErrorlabel);
            this.addApptGroupBox.Controls.Add(this.customerDataGridView);
            this.addApptGroupBox.Controls.Add(this.fillFieldsLabel);
            this.addApptGroupBox.Controls.Add(this.cancelButton);
            this.addApptGroupBox.Controls.Add(this.saveButton);
            this.addApptGroupBox.Controls.Add(this.endDateTimePicker);
            this.addApptGroupBox.Controls.Add(this.startDateTimePicker);
            this.addApptGroupBox.Controls.Add(this.urlTextBox);
            this.addApptGroupBox.Controls.Add(this.typeTextBox);
            this.addApptGroupBox.Controls.Add(this.contactTextBox);
            this.addApptGroupBox.Controls.Add(this.locationTextBox);
            this.addApptGroupBox.Controls.Add(this.descriptionTextBox);
            this.addApptGroupBox.Controls.Add(this.titleTextBox);
            this.addApptGroupBox.Controls.Add(this.endLabel);
            this.addApptGroupBox.Controls.Add(this.startLabel);
            this.addApptGroupBox.Controls.Add(this.urlLabel);
            this.addApptGroupBox.Controls.Add(this.typeLabel);
            this.addApptGroupBox.Controls.Add(this.contactLabel);
            this.addApptGroupBox.Controls.Add(this.locationLabel);
            this.addApptGroupBox.Controls.Add(this.descriptionLabel);
            this.addApptGroupBox.Controls.Add(this.titleLabel);
            this.addApptGroupBox.Location = new System.Drawing.Point(38, 34);
            this.addApptGroupBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.addApptGroupBox.Name = "addApptGroupBox";
            this.addApptGroupBox.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.addApptGroupBox.Size = new System.Drawing.Size(2559, 1073);
            this.addApptGroupBox.TabIndex = 2;
            this.addApptGroupBox.TabStop = false;
            this.addApptGroupBox.Text = "Enter Appointment information";
            // 
            // dateTimeErrorlabel
            // 
            this.dateTimeErrorlabel.AutoSize = true;
            this.dateTimeErrorlabel.ForeColor = System.Drawing.Color.Red;
            this.dateTimeErrorlabel.Location = new System.Drawing.Point(228, 919);
            this.dateTimeErrorlabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dateTimeErrorlabel.Name = "dateTimeErrorlabel";
            this.dateTimeErrorlabel.Size = new System.Drawing.Size(362, 37);
            this.dateTimeErrorlabel.TabIndex = 21;
            this.dateTimeErrorlabel.Text = "Please enter valid times.";
            this.dateTimeErrorlabel.Visible = false;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AllowUserToResizeColumns = false;
            this.customerDataGridView.AllowUserToResizeRows = false;
            this.customerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(662, 54);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.ShowCellErrors = false;
            this.customerDataGridView.ShowCellToolTips = false;
            this.customerDataGridView.ShowEditingIcon = false;
            this.customerDataGridView.ShowRowErrors = false;
            this.customerDataGridView.Size = new System.Drawing.Size(1878, 899);
            this.customerDataGridView.TabIndex = 20;
            // 
            // fillFieldsLabel
            // 
            this.fillFieldsLabel.AutoSize = true;
            this.fillFieldsLabel.ForeColor = System.Drawing.Color.Red;
            this.fillFieldsLabel.Location = new System.Drawing.Point(263, 68);
            this.fillFieldsLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.fillFieldsLabel.Name = "fillFieldsLabel";
            this.fillFieldsLabel.Size = new System.Drawing.Size(285, 37);
            this.fillFieldsLabel.TabIndex = 19;
            this.fillFieldsLabel.Text = "Please fill all fields.";
            this.fillFieldsLabel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(19, 971);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(253, 85);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(2286, 971);
            this.saveButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(253, 85);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(238, 854);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(397, 44);
            this.endDateTimePicker.TabIndex = 16;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(238, 766);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(397, 44);
            this.startDateTimePicker.TabIndex = 15;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(238, 683);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(397, 44);
            this.urlTextBox.TabIndex = 14;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(238, 598);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(397, 44);
            this.typeTextBox.TabIndex = 13;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(238, 512);
            this.contactTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(397, 44);
            this.contactTextBox.TabIndex = 12;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(238, 427);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(397, 44);
            this.locationTextBox.TabIndex = 11;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(238, 199);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(397, 192);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(238, 114);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(397, 44);
            this.titleTextBox.TabIndex = 9;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(133, 871);
            this.endLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(74, 37);
            this.endLabel.TabIndex = 8;
            this.endLabel.Text = "End";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(124, 783);
            this.startLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(85, 37);
            this.startLabel.TabIndex = 7;
            this.startLabel.Text = "Start";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(124, 692);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(80, 37);
            this.urlLabel.TabIndex = 6;
            this.urlLabel.Text = "URL";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(117, 606);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(87, 37);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(76, 521);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(128, 37);
            this.contactLabel.TabIndex = 4;
            this.contactLabel.Text = "Contact";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(63, 435);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(139, 37);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Location";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(25, 208);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(177, 37);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2635, 1141);
            this.Controls.Add(this.addApptGroupBox);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "AddAppointment";
            this.Text = "Add Appointment";
            this.addApptGroupBox.ResumeLayout(false);
            this.addApptGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox addApptGroupBox;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label fillFieldsLabel;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Label dateTimeErrorlabel;
    }
}