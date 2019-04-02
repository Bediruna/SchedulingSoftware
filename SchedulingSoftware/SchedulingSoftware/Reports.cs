using SchedulingSoftware.DataModels;
using SchedulingSoftware.SupportCode;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SchedulingSoftware
{
    public partial class Reports : Form
    {
        User currentUser;

        public Reports(User user)
        {
            currentUser = user;
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainScr = new MainScreen(currentUser);
            mainScr.Show();
        }

        private void apptTypesByMonthButton_Click(object sender, EventArgs e)
        {
            DataProcedures data = new DataProcedures();
            resultsGroupBox.Visible = true;
            resultsGroupBox.Text = "Appt Types By Month";
            resultTextBox.Text = string.Empty;

            string resultString = string.Empty;

            for (int i = 1; i <= 12; i++)
            {
                List<string> list = data.returnApptTypesByMonth(currentUser.userId, i);
                var q = from x in list
                        group x by x into g
                        let count = g.Count()
                        orderby count descending
                        select new { Value = g.Key, Count = count };

                resultString += Environment.NewLine + DateTimeFormatInfo.CurrentInfo.GetMonthName(i) + Environment.NewLine;
                foreach (var x in q)
                {
                    resultString += "Appointment type: " + x.Value + "\t Count: " + x.Count + Environment.NewLine;
                }
            }

            resultTextBox.Text = resultString;
        }

        private void consultantScheduleButton_Click(object sender, EventArgs e)
        {
            DataProcedures data = new DataProcedures();
            resultsGroupBox.Visible = true;
            resultsGroupBox.Text = "Consultants schedule";
            resultTextBox.Text = string.Empty;

            string resultString = string.Empty;

            List<int> userIdsDistinct = data.returnDistinctConsultantsWithAppts();

            userIdsDistinct.ForEach(varid =>
            {//lambda used to make foreach simpler
                List<Appointment> consultantAppts = data.returnUserSchedule(varid);
                resultString += "\n\nAppointments for user " + varid + "\n";
                consultantAppts.ForEach(appt =>
                {//lambda used to make foreach simpler
                    resultString += "\nStart: " + appt.start + "   End: " + appt.end + Environment.NewLine;
                });
            });

            resultTextBox.Text = resultString;
        }

        private void consultantHoursButton_Click(object sender, EventArgs e)
        {
            DataProcedures data = new DataProcedures();
            resultsGroupBox.Visible = true;
            resultsGroupBox.Text = "Consultants hours";
            resultTextBox.Text = string.Empty;

            string resultString = string.Empty;

            List<int> userIdsDistinct = data.returnDistinctConsultantsWithAppts();

            userIdsDistinct.ForEach(varid =>
            {//lambda used to make foreach simpler
                List<Appointment> consultantAppts = data.returnUserSchedule(varid);
                double totalHours = 0;
                consultantAppts.ForEach(appt =>
                {//lambda used to make foreach simpler
                    totalHours += (appt.end - appt.start).TotalHours;
                });

                resultString += "\n\nTotal hours for user " + varid + ": " + totalHours;
            });

            resultTextBox.Text = resultString;
        }
    }
}
