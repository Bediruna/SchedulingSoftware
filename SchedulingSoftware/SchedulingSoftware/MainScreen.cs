using SchedulingSoftware.DataModels;
using SchedulingSoftware.SupportCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace SchedulingSoftware
{
    public partial class MainScreen : Form
    {
        User currentUser;
        public MainScreen(User user)
        {
            InitializeComponent();
            currentUser = new User();
            currentUser = user;
            mainGroupBox.Text = "Hi " + user.username;

            DataProcedures data = new DataProcedures();

            customerDataGridView.DataSource = data.getCustomers();

            emboldenMonthCalendar();
        }

        private void emboldenMonthCalendar()
        {
            DataProcedures data = new DataProcedures();

            List<Appointment> appts = data.returnUserSchedule(currentUser.userId);


            DateTime[] datesToBold = new DateTime[60];

            int iterator = 0;
            appts.ForEach(appt =>
            {//lambda used to make foreach simpler
                datesToBold[iterator] = appt.start;
                iterator++;
            });

            monthCalendar.BoldedDates = datesToBold;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer addCustForm = new AddCustomer(currentUser);
            addCustForm.Show();
        }

        private void modifyCustButton_Click(object sender, EventArgs e)
        {
            int custSelected = Convert.ToInt32(customerDataGridView.Rows[customerDataGridView.CurrentCell.RowIndex].Cells[0].Value);//getting the integer value of the selected customer's ID

            if (custSelected != -1)
            {
                this.Hide();
                ModifyCustomer modCustForm = new ModifyCustomer(currentUser, custSelected);
                modCustForm.Show();
            }
            else
            {
                MessageBox.Show("There are no customers to modify.", "Error");
            }

        }

        private void deleteCustButton_Click(object sender, EventArgs e)
        {
            DialogResult deletePartDialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
            int custSelected = Convert.ToInt32(customerDataGridView.Rows[customerDataGridView.CurrentCell.RowIndex].Cells[0].Value);

            if (custSelected != -1)
            {
                if (deletePartDialogResult == DialogResult.Yes)
                {
                    DataProcedures data = new DataProcedures();
                    data.deleteCustomer(custSelected);
                    customerDataGridView.DataSource = data.getCustomers();//set data source to show current list
                }
            }
            else
            {
                MessageBox.Show("There are no customers to delete.", "Error");
            }

        }

        private void addApptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointment addApptForm = new AddAppointment(currentUser);
            addApptForm.Show();
        }

        private void modifyApptButton_Click(object sender, EventArgs e)
        {
            int apptSelected = Convert.ToInt32(apptDataGridView.Rows[apptDataGridView.CurrentCell.RowIndex].Cells[0].Value);

            if (apptSelected != -1)
            {
                this.Hide();
                ModifyAppointment modApptForm = new ModifyAppointment(currentUser, apptSelected);
                modApptForm.Show();
            }
            else
            {
                MessageBox.Show("There are no appointments to modify.", "Error");
            }
        }

        private void deleteApptButton_Click(object sender, EventArgs e)
        {
            DialogResult deleteApptDialogResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Delete appointment", MessageBoxButtons.YesNo);
            int apptSelected = Convert.ToInt32(apptDataGridView.Rows[apptDataGridView.CurrentCell.RowIndex].Cells[0].Value);

            if (apptSelected != -1)
            {
                if (deleteApptDialogResult == DialogResult.Yes)
                {
                    DataProcedures data = new DataProcedures();
                    data.deleteAppointment(apptSelected);
                    int custSelected = Convert.ToInt32(customerDataGridView.Rows[customerDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                    apptDataGridView.DataSource = data.getAppointments(custSelected, currentUser.userId);
                }
            }
            else
            {
                MessageBox.Show("There are no appointments to delete.", "Error");
            }
        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataProcedures data = new DataProcedures();

            int custSelected = Convert.ToInt32(customerDataGridView.Rows[customerDataGridView.CurrentCell.RowIndex].Cells[0].Value);
            apptDataGridView.DataSource = data.getAppointments(custSelected, currentUser.userId);
            apptGroupBox.Text = "Appointments for " + customerDataGridView.Rows[customerDataGridView.CurrentCell.RowIndex].Cells[1].Value;
        }

        int weekOfTheYear;
        private void weeklyButton_Click(object sender, EventArgs e)
        {
            DataProcedures data = new DataProcedures();

            if (weeklyButton.Text == "View Monthly")
            {
                weeklyDataGridView.Hide();
                prevWeekButton.Hide();
                nextWeekButton.Hide();
                weekLabel.Hide();
                weeklyButton.Text = "View Weekly";
                monthCalendar.Show();
            }
            else
            {
                weeklyDataGridView.Show();
                prevWeekButton.Show();
                nextWeekButton.Show();
                weekLabel.Show();


                //Code was referrenced from: https://docs.microsoft.com/en-us/dotnet/api/system.globalization.calendar.getweekofyear?view=netframework-4.7.2
                // Gets the Calendar instance associated with a CultureInfo.
                CultureInfo myCI = new CultureInfo("en-US");
                Calendar myCal = myCI.Calendar;

                // Gets the DTFI properties required by GetWeekOfYear.
                CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
                DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

                weekOfTheYear = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
                setWeeklyCalendar();

                weekLabel.Text = "Week " + weekOfTheYear;
                weeklyButton.Text = "View Monthly";
                monthCalendar.Hide();

            }
        }
        DataTable weeklyDataTable;
        private void setWeeklyCalendar()
        {
            DataProcedures data = new DataProcedures();

            List<Appointment> weeksAppointments = data.getWeeksAppts(currentUser.userId, weekOfTheYear);

            weeklyDataTable = new DataTable();

            //If column does not exist, add column.
            if (!weeklyDataTable.Columns.Contains("SUN")) { weeklyDataTable.Columns.Add("SUN", typeof(string)); }
            if (!weeklyDataTable.Columns.Contains("MON")) { weeklyDataTable.Columns.Add("MON", typeof(string)); }
            if (!weeklyDataTable.Columns.Contains("TUE")) { weeklyDataTable.Columns.Add("TUE", typeof(string)); }
            if (!weeklyDataTable.Columns.Contains("WED")) { weeklyDataTable.Columns.Add("WED", typeof(string)); }
            if (!weeklyDataTable.Columns.Contains("THU")) { weeklyDataTable.Columns.Add("THU", typeof(string)); }
            if (!weeklyDataTable.Columns.Contains("FRI")) { weeklyDataTable.Columns.Add("FRI", typeof(string)); }
            if (!weeklyDataTable.Columns.Contains("SAT")) { weeklyDataTable.Columns.Add("SAT", typeof(string)); }


            weeklyDataGridView.DataSource = weeklyDataTable;

            weeksAppointments.ForEach(appt =>
            {
                DataRow dataRow;

                switch (appt.start.DayOfWeek.ToString())//Get the day of week for each start date for appointments in week. To put in correct column
                {
                    case "Sunday":
                        dataRow = weeklyDataTable.Rows.Add();
                        dataRow[0] = appt.title;
                        break;
                    case "Monday":
                        dataRow = weeklyDataTable.Rows.Add();
                        dataRow[1] = appt.title;
                        break;
                    case "Tuesday":
                        dataRow = weeklyDataTable.Rows.Add();
                        dataRow[2] = appt.title;
                        break;
                    case "Wednesday":
                        dataRow = weeklyDataTable.Rows.Add();
                        dataRow[3] = appt.title;
                        break;
                    case "Thursday":
                        dataRow = weeklyDataTable.Rows.Add();
                        dataRow[4] = appt.title;
                        break;
                    case "Friday":
                        dataRow = weeklyDataTable.Rows.Add();
                        dataRow[5] = appt.title;
                        break;
                    case "Saturday":
                        dataRow = weeklyDataTable.Rows.Add();
                        dataRow[6] = appt.title;
                        break;
                }
            });
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reportsForm = new Reports(currentUser);
            reportsForm.Show();
        }

        private void prevWeekButton_Click(object sender, EventArgs e)
        {
            if (weekOfTheYear > 0)
            {
                weekOfTheYear--;
                weekLabel.Text = "Week " + weekOfTheYear;
            }
            weeklyDataTable.Clear();
            setWeeklyCalendar();
        }

        private void nextWeekButton_Click(object sender, EventArgs e)
        {
            if (weekOfTheYear < 53)
            {
                weekOfTheYear++;
                weekLabel.Text = "Week " + weekOfTheYear;
            }
            weeklyDataTable.Clear();
            setWeeklyCalendar();
        }
    }
}
