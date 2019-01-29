using SchedulingSoftware.DataModels;
using SchedulingSoftware.SupportCode;
using System;
using System.Windows.Forms;

namespace SchedulingSoftware
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            User userInfo = new User(usernameTextbox.Text, passwordTextbox.Text);
            DataProcedures data = new DataProcedures();

            if (string.IsNullOrEmpty(usernameTextbox.Text) && string.IsNullOrEmpty(passwordTextbox.Text))
            {
                enterInfolabel.Visible = true;
            }
            else
            {
                if (confirmPassTextBox.Text.Equals(passwordTextbox.Text))
                {
                    if (data.registerUser(userInfo))
                    {
                        this.Hide();
                        LogIn logInForm = new LogIn();
                        logInForm.Show();
                    }
                }
                else
                {
                    mismatchLabel.Visible = true;
                }
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
