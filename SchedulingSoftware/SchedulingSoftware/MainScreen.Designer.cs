namespace SchedulingSoftware
{
    partial class MainScreen
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
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.weeklyButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.apptGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteApptButton = new System.Windows.Forms.Button();
            this.modifyApptButton = new System.Windows.Forms.Button();
            this.addApptButton = new System.Windows.Forms.Button();
            this.apptDataGridView = new System.Windows.Forms.DataGridView();
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteCustButton = new System.Windows.Forms.Button();
            this.modifyCustButton = new System.Windows.Forms.Button();
            this.addCustButton = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.weeklyDataGridView = new System.Windows.Forms.DataGridView();
            this.mainGroupBox.SuspendLayout();
            this.apptGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apptDataGridView)).BeginInit();
            this.customerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGroupBox.Controls.Add(this.weeklyButton);
            this.mainGroupBox.Controls.Add(this.reportsButton);
            this.mainGroupBox.Controls.Add(this.exitButton);
            this.mainGroupBox.Controls.Add(this.apptGroupBox);
            this.mainGroupBox.Controls.Add(this.customerGroupBox);
            this.mainGroupBox.Controls.Add(this.monthCalendar);
            this.mainGroupBox.Controls.Add(this.weeklyDataGridView);
            this.mainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(1281, 447);
            this.mainGroupBox.TabIndex = 0;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "User";
            // 
            // weeklyButton
            // 
            this.weeklyButton.Location = new System.Drawing.Point(700, 373);
            this.weeklyButton.Margin = new System.Windows.Forms.Padding(2);
            this.weeklyButton.Name = "weeklyButton";
            this.weeklyButton.Size = new System.Drawing.Size(80, 30);
            this.weeklyButton.TabIndex = 4;
            this.weeklyButton.Text = "View Weekly";
            this.weeklyButton.UseVisualStyleBackColor = true;
            this.weeklyButton.Click += new System.EventHandler(this.weeklyButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Location = new System.Drawing.Point(6, 411);
            this.reportsButton.Margin = new System.Windows.Forms.Padding(2);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(80, 30);
            this.reportsButton.TabIndex = 1;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(1195, 411);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 30);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // apptGroupBox
            // 
            this.apptGroupBox.Controls.Add(this.deleteApptButton);
            this.apptGroupBox.Controls.Add(this.modifyApptButton);
            this.apptGroupBox.Controls.Add(this.addApptButton);
            this.apptGroupBox.Controls.Add(this.apptDataGridView);
            this.apptGroupBox.Location = new System.Drawing.Point(875, 19);
            this.apptGroupBox.Name = "apptGroupBox";
            this.apptGroupBox.Size = new System.Drawing.Size(400, 390);
            this.apptGroupBox.TabIndex = 3;
            this.apptGroupBox.TabStop = false;
            this.apptGroupBox.Text = "Appointments";
            // 
            // deleteApptButton
            // 
            this.deleteApptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteApptButton.Location = new System.Drawing.Point(314, 354);
            this.deleteApptButton.Name = "deleteApptButton";
            this.deleteApptButton.Size = new System.Drawing.Size(80, 30);
            this.deleteApptButton.TabIndex = 6;
            this.deleteApptButton.Text = "Delete";
            this.deleteApptButton.UseVisualStyleBackColor = true;
            this.deleteApptButton.Click += new System.EventHandler(this.deleteApptButton_Click);
            // 
            // modifyApptButton
            // 
            this.modifyApptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyApptButton.Location = new System.Drawing.Point(228, 354);
            this.modifyApptButton.Name = "modifyApptButton";
            this.modifyApptButton.Size = new System.Drawing.Size(80, 30);
            this.modifyApptButton.TabIndex = 5;
            this.modifyApptButton.Text = "Modify";
            this.modifyApptButton.UseVisualStyleBackColor = true;
            this.modifyApptButton.Click += new System.EventHandler(this.modifyApptButton_Click);
            // 
            // addApptButton
            // 
            this.addApptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addApptButton.Location = new System.Drawing.Point(142, 354);
            this.addApptButton.Name = "addApptButton";
            this.addApptButton.Size = new System.Drawing.Size(80, 30);
            this.addApptButton.TabIndex = 4;
            this.addApptButton.Text = "Add";
            this.addApptButton.UseVisualStyleBackColor = true;
            this.addApptButton.Click += new System.EventHandler(this.addApptButton_Click);
            // 
            // apptDataGridView
            // 
            this.apptDataGridView.AllowUserToAddRows = false;
            this.apptDataGridView.AllowUserToDeleteRows = false;
            this.apptDataGridView.AllowUserToResizeColumns = false;
            this.apptDataGridView.AllowUserToResizeRows = false;
            this.apptDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apptDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.apptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptDataGridView.Location = new System.Drawing.Point(6, 19);
            this.apptDataGridView.MultiSelect = false;
            this.apptDataGridView.Name = "apptDataGridView";
            this.apptDataGridView.ReadOnly = true;
            this.apptDataGridView.RowHeadersVisible = false;
            this.apptDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.apptDataGridView.ShowCellErrors = false;
            this.apptDataGridView.ShowCellToolTips = false;
            this.apptDataGridView.ShowEditingIcon = false;
            this.apptDataGridView.ShowRowErrors = false;
            this.apptDataGridView.Size = new System.Drawing.Size(388, 311);
            this.apptDataGridView.TabIndex = 0;
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.deleteCustButton);
            this.customerGroupBox.Controls.Add(this.modifyCustButton);
            this.customerGroupBox.Controls.Add(this.addCustButton);
            this.customerGroupBox.Controls.Add(this.customerDataGridView);
            this.customerGroupBox.Location = new System.Drawing.Point(6, 19);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(603, 390);
            this.customerGroupBox.TabIndex = 2;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customers";
            // 
            // deleteCustButton
            // 
            this.deleteCustButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCustButton.Location = new System.Drawing.Point(517, 354);
            this.deleteCustButton.Name = "deleteCustButton";
            this.deleteCustButton.Size = new System.Drawing.Size(80, 30);
            this.deleteCustButton.TabIndex = 3;
            this.deleteCustButton.Text = "Delete";
            this.deleteCustButton.UseVisualStyleBackColor = true;
            this.deleteCustButton.Click += new System.EventHandler(this.deleteCustButton_Click);
            // 
            // modifyCustButton
            // 
            this.modifyCustButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyCustButton.Location = new System.Drawing.Point(431, 354);
            this.modifyCustButton.Name = "modifyCustButton";
            this.modifyCustButton.Size = new System.Drawing.Size(80, 30);
            this.modifyCustButton.TabIndex = 2;
            this.modifyCustButton.Text = "Modify";
            this.modifyCustButton.UseVisualStyleBackColor = true;
            this.modifyCustButton.Click += new System.EventHandler(this.modifyCustButton_Click);
            // 
            // addCustButton
            // 
            this.addCustButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustButton.Location = new System.Drawing.Point(345, 354);
            this.addCustButton.Name = "addCustButton";
            this.addCustButton.Size = new System.Drawing.Size(80, 30);
            this.addCustButton.TabIndex = 1;
            this.addCustButton.Text = "Add";
            this.addCustButton.UseVisualStyleBackColor = true;
            this.addCustButton.Click += new System.EventHandler(this.addCustButton_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AllowUserToResizeColumns = false;
            this.customerDataGridView.AllowUserToResizeRows = false;
            this.customerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(6, 19);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.ShowCellErrors = false;
            this.customerDataGridView.ShowCellToolTips = false;
            this.customerDataGridView.ShowEditingIcon = false;
            this.customerDataGridView.ShowRowErrors = false;
            this.customerDataGridView.Size = new System.Drawing.Size(591, 311);
            this.customerDataGridView.TabIndex = 0;
            this.customerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellClick);
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar.Location = new System.Drawing.Point(628, 38);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            // 
            // weeklyDataGridView
            // 
            this.weeklyDataGridView.AllowUserToAddRows = false;
            this.weeklyDataGridView.AllowUserToDeleteRows = false;
            this.weeklyDataGridView.AllowUserToResizeColumns = false;
            this.weeklyDataGridView.AllowUserToResizeRows = false;
            this.weeklyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weeklyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.weeklyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyDataGridView.Location = new System.Drawing.Point(615, 38);
            this.weeklyDataGridView.MultiSelect = false;
            this.weeklyDataGridView.Name = "weeklyDataGridView";
            this.weeklyDataGridView.ReadOnly = true;
            this.weeklyDataGridView.RowHeadersVisible = false;
            this.weeklyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.weeklyDataGridView.ShowCellErrors = false;
            this.weeklyDataGridView.ShowCellToolTips = false;
            this.weeklyDataGridView.ShowEditingIcon = false;
            this.weeklyDataGridView.ShowRowErrors = false;
            this.weeklyDataGridView.Size = new System.Drawing.Size(254, 311);
            this.weeklyDataGridView.TabIndex = 7;
            this.weeklyDataGridView.Visible = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 471);
            this.Controls.Add(this.mainGroupBox);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.mainGroupBox.ResumeLayout(false);
            this.apptGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apptDataGridView)).EndInit();
            this.customerGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.GroupBox apptGroupBox;
        private System.Windows.Forms.Button deleteApptButton;
        private System.Windows.Forms.Button modifyApptButton;
        private System.Windows.Forms.Button addApptButton;
        private System.Windows.Forms.DataGridView apptDataGridView;
        private System.Windows.Forms.Button deleteCustButton;
        private System.Windows.Forms.Button modifyCustButton;
        private System.Windows.Forms.Button addCustButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button weeklyButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.DataGridView weeklyDataGridView;
    }
}