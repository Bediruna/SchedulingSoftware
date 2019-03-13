using SchedulingSoftware.DataModels;
using SchedulingSoftware.SupportCode;
using System;
using System.Collections.Generic;
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
            resultLabel.Text = string.Empty;

            string janString = string.Empty;
            string febString = string.Empty;
            string marString = string.Empty;
            string aprString = string.Empty;
            string mayString = string.Empty;
            string junString = string.Empty;
            string julString = string.Empty;
            string augString = string.Empty;
            string sepString = string.Empty;
            string octString = string.Empty;
            string novString = string.Empty;
            string decString = string.Empty;

            foreach (var apptMonth in data.returnApptTypesByMonth(currentUser.userId, 1))
            {
                janString += apptMonth.type + ", ";
            }
            foreach (var apptMonth in data.returnApptTypesByMonth(currentUser.userId, 2))
            {
                febString += apptMonth.type + ", ";
            }
            foreach (var apptMonth in data.returnApptTypesByMonth(currentUser.userId, 3))
            {
                marString += apptMonth.type + ", ";
            }
            foreach (var apptMonth in data.returnApptTypesByMonth(currentUser.userId, 4))
            {
                aprString += apptMonth.type + ", ";
            }
            foreach (var apptMonth in data.returnApptTypesByMonth(currentUser.userId, 5))
            {
                mayString += apptMonth.type + ", ";
            }            
            foreach (var apptMonth in data.returnApptTypesByMonth(currentUser.userId, 6))
            {
                junString += apptMonth.type + ", ";
            }            
            foreach (var apptMonth in data.returnApptTypesByMonth(currentUser.userId, 7))
            {
                julString += apptMonth.type + ", ";
            }            
            foreach (var apptMonth in data.returnApptTypesByMonth(currentUser.userId, 8))
            {
                augString += apptMonth.type + ", ";
            }            
            foreach (var apptMonth in data.returnApptTypesByMonth(currentUser.userId, 9))
            {
                sepString += apptMonth.type + ", ";
            }            
            foreach (var apptMonth in data.returnApptTypesByMonth(currentUser.userId, 10))
            {
                octString += apptMonth.type + ", ";
            }
            foreach (var apptMonth in data.returnApptTypesByMonth(currentUser.userId, 11))
            {
                novString += apptMonth.type + ", ";
            }            
            foreach (var apptMonth in data.returnApptTypesByMonth(currentUser.userId, 12))
            {
                decString += apptMonth.type + ", ";
            }

            resultLabel.Text =
                "January: " + janString +
                "\nFebruary: " + febString +
                "\nMarch: " + marString +
                "\nApril: " + aprString +
                "\nMay: " + mayString +
                "\nJune: " + junString +
                "\nJuly: " + julString +
                "\nAugust: " + augString +
                "\nSeptember: " + sepString +
                "\nOctober: " + octString +
                "\nNovember: " + novString +
                "\nDecember: " + decString
                ;
        }

        private void consultantScheduleButton_Click(object sender, EventArgs e)
        {
            DataProcedures data = new DataProcedures();
            resultsGroupBox.Visible = true;
            resultsGroupBox.Text = "Consultants schedule";
            resultLabel.Text = string.Empty;

            string resultString = string.Empty;

            List<int> userIdsDistinct = data.returnDistinctConsultantsWithAppts();

            userIdsDistinct.ForEach(varid => {//lambda used to make foreach simpler
                List<Appointment> consultantAppts = data.returnUserSchedule(varid);
                resultString += "\n\nAppointments for user " + varid + "";
                consultantAppts.ForEach(appt => {//lambda used to make foreach simpler
                    resultString += "\nStart: " + appt.start + "   End: " + appt.end;
                });
            });

            resultLabel.Text = resultString;
        }

        private void consultantHoursButton_Click(object sender, EventArgs e)
        {
            DataProcedures data = new DataProcedures();
            resultsGroupBox.Visible = true;
            resultsGroupBox.Text = "Consultants hours";
            resultLabel.Text = string.Empty;

            string resultString = string.Empty;

            List<int> userIdsDistinct = data.returnDistinctConsultantsWithAppts();

            userIdsDistinct.ForEach(varid => {//lambda used to make foreach simpler
                List<Appointment> consultantAppts = data.returnUserSchedule(varid);                
                double totalHours = 0;
                consultantAppts.ForEach(appt => {//lambda used to make foreach simpler
                    totalHours += (appt.end - appt.start).TotalHours;                    
                });

                resultString += "\n\nTotal hours for user " + varid + ": " + totalHours;
            });

            resultLabel.Text = resultString;
        }
    }
}
