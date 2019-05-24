using SchedulingSoftware.DataModels;
using SchedulingSoftware.SupportCode;
using System.Windows.Forms;

namespace SchedulingSoftware
{
    public partial class Reminder : Form
    {
        public Reminder(Appointment appt)
        {
            InitializeComponent();
            DataProcedures data = new DataProcedures();
            string customerName = data.getCustomerInformation(appt.customerId).customerName;

            headMsg.Text += customerName;
            titleTextBox.Text = appt.title;
            descriptionTextBox.Text = appt.description;
            locationTextBox.Text = appt.location;
            contactTextBox.Text = appt.contact;
            typeTextBox.Text = appt.type;
            urlTextBox.Text = appt.url;
            startDateTimePicker.Value = appt.start.ToLocalTime();
            endDateTimePicker.Value = appt.end.ToLocalTime();
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
