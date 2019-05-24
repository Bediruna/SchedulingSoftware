using SchedulingSoftware.DataModels;
using SchedulingSoftware.SupportCode;
using System;
using System.Windows.Forms;

namespace SchedulingSoftware
{
    public partial class ModifyAppointment : Form
    {
        User currentUser;
        int apptId;
        bool validAppt;
        public ModifyAppointment(User user, int modifiedApptId)
        {
            InitializeComponent();
            apptId = modifiedApptId;
            currentUser = user;

            DataProcedures data = new DataProcedures();

            customerDataGridView.DataSource = data.getCustomers();

            Appointment appt = data.getAppointmentInformation(apptId);

            appt.userId = currentUser.userId;
            titleTextBox.Text = appt.title;
            descriptionTextBox.Text = appt.description;
            locationTextBox.Text = appt.location;
            contactTextBox.Text = appt.contact;
            typeTextBox.Text = appt.type;
            urlTextBox.Text = appt.url;
            startDateTimePicker.Value = appt.start.ToLocalTime();
            endDateTimePicker.Value = appt.end.ToLocalTime();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DataProcedures data = new DataProcedures();

            bool overlap = data.checkForOverlappingAppointmentsWhenModifying(startDateTimePicker.Value.ToUniversalTime(), endDateTimePicker.Value.ToUniversalTime(), apptId);

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

            bool overlap = data.checkForOverlappingAppointmentsWhenModifying(startDateTimePicker.Value.ToUniversalTime(), endDateTimePicker.Value.ToUniversalTime(), apptId);

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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainScr = new MainScreen(currentUser);
            mainScr.Show();
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

            if (textBoxesNotEmpty)
            {
                if (validAppt)
                {
                    int custSelected = Convert.ToInt32(customerDataGridView.Rows[customerDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                    Appointment appt = new Appointment();
                    appt.appointmentId = apptId;
                    appt.customerId = custSelected;
                    appt.userId = currentUser.userId;
                    appt.title = titleTextBox.Text;
                    appt.description = descriptionTextBox.Text;
                    appt.location = locationTextBox.Text;
                    appt.contact = contactTextBox.Text;
                    appt.type = typeTextBox.Text;
                    appt.url = urlTextBox.Text;
                    appt.start = startDateTimePicker.Value.ToUniversalTime();
                    appt.end = endDateTimePicker.Value.ToUniversalTime();

                    DataProcedures data = new DataProcedures();

                    if (data.updateAppointment(appt))
                    {
                        MainScreen mainScreen = new MainScreen(currentUser);
                        this.Hide();
                        mainScreen.Show();
                    }
                }
                else
                {
                    dateTimeErrorlabel.Text = "Please enter valid times.";
                    dateTimeErrorlabel.Left = 72;
                    dateTimeErrorlabel.Visible = true;
                }
            }
            else
            {
                fillFieldsLabel.Visible = true;
            }

        }
    }
}
