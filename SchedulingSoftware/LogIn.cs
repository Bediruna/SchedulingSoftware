using SchedulingSoftware.DataModels;
using SchedulingSoftware.SupportCode;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;


namespace SchedulingSoftware
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

            showCorrectLang();
        }

        private void showCorrectLang()
        {
            switch (RegionInfo.CurrentRegion.EnglishName)//The full name of the country/region in English.
            {
                case "United States":
                    showInEnglish();
                    break;
                case "Turkey":
                    showInTurkish();
                    break;

                default:
                    showInEnglish();
                    break;
            }
        }

        private void showInEnglish()
        {
            this.Text = "Log In";
            loginGroupBox.Text = "Please enter log in information.";
            errorLabel.Text = "The username and password did not match.";
            usernameLabel.Text = "Username";
            passwordLabel.Text = "Password";
            signInButton.Text = "Sign in";
            registerButton.Text = "Register";
            exitButton.Text = "Exit";
        }

        private void showInTurkish()
        {
            this.Text = "Giriş";
            loginGroupBox.Text = "Lütfen giriş bilgilerinizi girin.";
            errorLabel.Text = "Kullanıcı adı ve şifre bulunamadı.";
            usernameLabel.Text = "Kullanıcı";
            passwordLabel.Text = "Şifre";
            signInButton.Text = "Oturum aç";
            registerButton.Text = "Kayıt ol";
            exitButton.Text = "Kapat";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration regForm = new Registration();
            regForm.Show();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            DataProcedures data = new DataProcedures();
            User userInfo = new User(usernameTextbox.Text, passwordTextbox.Text);
            userInfo.userId = data.verifyUser(userInfo);

            if (userInfo.userId != -1)
            {
                DateTime dateTime = DateTime.Now;
                data.logUserActivity("Username: '" + userInfo.username + "'. UserID: " + userInfo.userId + ". Logged in at " + dateTime);
                this.Hide();
                MainScreen mainScr = new MainScreen(userInfo);
                mainScr.Show();
                //Show upcoming appts when user signs in.
                List<Appointment> upcomingAppts = data.checkUserReminders(userInfo.userId);
                if (upcomingAppts.Count > 0)
                {
                    foreach (var appt in upcomingAppts)
                    {
                        Reminder apptReminder = new Reminder(appt);
                        apptReminder.Show();
                    }
                }
            }
            else
            {
                errorLabel.Show();
            }
        }
    }
}
