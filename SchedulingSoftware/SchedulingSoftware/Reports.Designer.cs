namespace SchedulingSoftware
{
    partial class Reports
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
            this.apptTypesByMonthButton = new System.Windows.Forms.Button();
            this.consultantScheduleButton = new System.Windows.Forms.Button();
            this.consultantHoursButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // apptTypesByMonthButton
            // 
            this.apptTypesByMonthButton.Location = new System.Drawing.Point(12, 12);
            this.apptTypesByMonthButton.Name = "apptTypesByMonthButton";
            this.apptTypesByMonthButton.Size = new System.Drawing.Size(150, 30);
            this.apptTypesByMonthButton.TabIndex = 0;
            this.apptTypesByMonthButton.Text = "Show Appt Types by Month";
            this.apptTypesByMonthButton.UseVisualStyleBackColor = true;
            this.apptTypesByMonthButton.Click += new System.EventHandler(this.apptTypesByMonthButton_Click);
            // 
            // consultantScheduleButton
            // 
            this.consultantScheduleButton.Location = new System.Drawing.Point(168, 12);
            this.consultantScheduleButton.Name = "consultantScheduleButton";
            this.consultantScheduleButton.Size = new System.Drawing.Size(150, 30);
            this.consultantScheduleButton.TabIndex = 1;
            this.consultantScheduleButton.Text = "Schedule for Consultants";
            this.consultantScheduleButton.UseVisualStyleBackColor = true;
            this.consultantScheduleButton.Click += new System.EventHandler(this.consultantScheduleButton_Click);
            // 
            // consultantHoursButton
            // 
            this.consultantHoursButton.Location = new System.Drawing.Point(324, 12);
            this.consultantHoursButton.Name = "consultantHoursButton";
            this.consultantHoursButton.Size = new System.Drawing.Size(150, 30);
            this.consultantHoursButton.TabIndex = 2;
            this.consultantHoursButton.Text = "Consultant Hours";
            this.consultantHoursButton.UseVisualStyleBackColor = true;
            this.consultantHoursButton.Click += new System.EventHandler(this.consultantHoursButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(412, 351);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 30);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.Location = new System.Drawing.Point(12, 351);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 30);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.resultTextBox);
            this.resultsGroupBox.Location = new System.Drawing.Point(12, 51);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(462, 283);
            this.resultsGroupBox.TabIndex = 20;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Appt Types By Month";
            this.resultsGroupBox.Visible = false;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTextBox.Location = new System.Drawing.Point(3, 16);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(456, 264);
            this.resultTextBox.TabIndex = 1;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 384);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.consultantHoursButton);
            this.Controls.Add(this.consultantScheduleButton);
            this.Controls.Add(this.apptTypesByMonthButton);
            this.Name = "Reports";
            this.Text = "Reports";
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button apptTypesByMonthButton;
        private System.Windows.Forms.Button consultantScheduleButton;
        private System.Windows.Forms.Button consultantHoursButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}