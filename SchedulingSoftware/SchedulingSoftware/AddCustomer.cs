using SchedulingSoftware.DataModels;
using SchedulingSoftware.SupportCode;
using System;
using System.Windows.Forms;

namespace SchedulingSoftware
{
    public partial class AddCustomer : Form
    {
        User currentUser;
        public AddCustomer(User user)
        {
            InitializeComponent();
            currentUser = new User();
            currentUser.username = user.username;
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
                DataProcedures data = new DataProcedures();

                Customer customer = new Customer();
                Address address = new Address();
                City city = new City();
                Country country = new Country();

                customer.customerName = nameTextBox.Text;

                customer.createdBy = currentUser.username;
                address.createdBy = currentUser.username;
                city.createdBy = currentUser.username;
                country.createdBy = currentUser.username;

                address.address = addressTextBox.Text;
                address.address2 = address2TextBox.Text;
                address.postalCode = postalCodeTextBox.Text;
                address.phone = phNumberTextBox.Text;

                city.city = cityTextBox.Text;

                country.country = countryTextBox.Text;

                city.countryId = data.addCountry(country);
                address.cityId = data.addCity(city);
                customer.addressId = data.addAddress(address);

                if (data.addCustomer(customer))
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
