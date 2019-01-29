using SchedulingSoftware.DataModels;
using SchedulingSoftware.SupportCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSoftware
{
    public partial class AddAppointment : Form
    {
        User currentUser;
        bool validAppt;
        public AddAppointment(User user)
        {
            InitializeComponent();
            currentUser = new User();
            currentUser.username = user.username;
            currentUser.userId = user.userId;

            DataProcedures data = new DataProcedures();

            customerDataGridView.DataSource = data.getCustomers();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DataProcedures data = new DataProcedures();

            bool overlap = data.checkForOverlappingAppointments(startDateTimePicker.Value.ToUniversalTime(), endDateTimePicker.Value.ToUniversalTime());

            if (overlap)
            {
                validAppt = false;
                dateTimeErrorlabel.Text = "There are overlapping appt times.";
                dateTimeErrorlabel.Left = 42;
                dateTimeErrorlabel.Visible = true;
            }
            else
            {
                dateTimeErrorlabel.Visible = false;
            }

            if (startDateTimePicker.Value.ToUniversalTime() < endDateTimePicker.Value.ToUniversalTime())
            {
                if (!overlap)
                {
                    validAppt = true;
                }
            }
            else
            {
                validAppt = false;
                dateTimeErrorlabel.Text = "Please enter valid times.";
                dateTimeErrorlabel.Left = 72;
                dateTimeErrorlabel.Visible = true;
            }

        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DataProcedures data = new DataProcedures();

            bool overlap = data.checkForOverlappingAppointments(startDateTimePicker.Value.ToUniversalTime(), endDateTimePicker.Value.ToUniversalTime());

            if (overlap)
            {
                validAppt = false;
                dateTimeErrorlabel.Text = "There are overlapping appt times.";
                dateTimeErrorlabel.Left = 42;
                dateTimeErrorlabel.Visible = true;
            }
            else
            {
                dateTimeErrorlabel.Visible = false;
            }

            if (startDateTimePicker.Value.ToUniversalTime() < endDateTimePicker.Value.ToUniversalTime())
            {
                if (!overlap)
                {
                    validAppt = true;
                }
            }
            else
            {
                validAppt = false;
                dateTimeErrorlabel.Text = "Please enter valid times.";
                dateTimeErrorlabel.Left = 72;
                dateTimeErrorlabel.Visible = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            bool textBoxesNotEmpty;

            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else if (string.IsNullOrWhiteSpace(locationTextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else if (string.IsNullOrWhiteSpace(contactTextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else if (string.IsNullOrWhiteSpace(typeTextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else if (string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else
            {
                textBoxesNotEmpty = true;
            }

            if (textBoxesNotEmpty && validAppt)
            {
                int custSelected = Convert.ToInt32(customerDataGridView.Rows[customerDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                Appointment appt = new Appointment();
                appt.customerId = custSelected;
                appt.userId = currentUser.userId;
                appt.title = titleTextBox.Text;
                appt.description = descriptionTextBox.Text;
                appt.location = locationTextBox.Text;
                appt.contact = contactTextBox.Text;
                appt.type = typeTextBox.Text;
                appt.url = urlTextBox.Text;
                appt.start = startDateTimePicker.Value.ToUniversalTime();//all times are stored and compared as UTC, and displayed to the user in their local time.
                appt.end = endDateTimePicker.Value.ToUniversalTime();

                DataProcedures data = new DataProcedures();

                if (data.addAppointment(appt) != -1)
                {
                    MainScreen mainScreen = new MainScreen(currentUser);
                    this.Hide();
                    mainScreen.Show();
                }
            }
            else
            {
                fillFieldsLabel.Visible = true;
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainScr = new MainScreen(currentUser);
            mainScr.Show();
        }


    }
}
