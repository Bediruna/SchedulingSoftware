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
    public partial class ModifyCustomer : Form
    {
        User currentUser;
        int custId;
        public ModifyCustomer(User user, int modifiedCustId)
        {
            InitializeComponent();
            custId = modifiedCustId;
            currentUser = user;

            DataProcedures data = new DataProcedures();

            CustomerInformation custInfo = data.getCustomerInformation(custId);

            nameTextBox.Text = custInfo.customerName;
            phNumberTextBox.Text = custInfo.phone;
            addressTextBox.Text = custInfo.address;
            address2TextBox.Text = custInfo.address2;
            cityTextBox.Text = custInfo.city;
            postalCodeTextBox.Text = custInfo.postalCode;
            countryTextBox.Text = custInfo.country;

            custGroupBox.Text = "Customer " + modifiedCustId.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool textBoxesNotEmpty;

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else if (string.IsNullOrWhiteSpace(phNumberTextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else if (string.IsNullOrWhiteSpace(address2TextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else if (string.IsNullOrWhiteSpace(postalCodeTextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else if (string.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                textBoxesNotEmpty = false;
            }
            else
            {
                textBoxesNotEmpty = true;
            }

            if (textBoxesNotEmpty)
            {
                DataProcedures dbProcedure = new DataProcedures();

                CustomerInformation custInfo = new CustomerInformation();
                custInfo.customerID = custId;
                custInfo.customerName = nameTextBox.Text;
                custInfo.phone = phNumberTextBox.Text;
                custInfo.address = addressTextBox.Text;
                custInfo.address2 = address2TextBox.Text;
                custInfo.city = cityTextBox.Text;
                custInfo.postalCode = postalCodeTextBox.Text;
                custInfo.country = countryTextBox.Text;

                bool insertCustomerInfo = dbProcedure.saveCustomerInformaion(custInfo);

                if (insertCustomerInfo)
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
