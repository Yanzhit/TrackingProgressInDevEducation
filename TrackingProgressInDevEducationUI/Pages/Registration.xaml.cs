using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using TrackingProgressInDevEducationDAL;
using static TrackingProgressInDevEducationUI.Defines;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private readonly MainForm _mainForm;
        private readonly FacadeManager _manager = new();
        public Registration(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            SignIn signIn = new(_mainForm);
            _mainForm.Content = signIn;
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            bool isRegistration = Verification();
            if (isRegistration)
            {
                Dictionary<string, string> param = WriteParams(); 
                //_manager.Lectors.SetNewLector(param["Name"], param["Email"], param["Password"]);
                EmailSend(FullNameInput.Text, EmailInput.Text);
            }
        }

        private Dictionary<string, string> WriteParams()
        {
            Dictionary<string, string> param = new()
            {
                {"Name", FullNameInput.Text}, {"Email", EmailInput.Text}, {"Password", PasswordInput.Text}
            };
            return param;
        }

        private bool Verification()
        {
            bool tmp = true;
            if (FullNameInput.Text.Length is < 6 or > 50)
            {
                InfoText.Text += $"{ExepFNameLength}{NewLine}";
                tmp = false;
            }
            if(EmailInput.Text.Length is < 1 or > 25)
            {
                InfoText.Text +=  $"{ExepEmailLength}{NewLine}";
                tmp = false;
            }

            if (PasswordInput.Text.Length is < 1 or > 12)
            {
                InfoText.Text +=  $"{ExepPasswordLength}{NewLine}";
                tmp = false;
            }

            if (PasswordInput.Text != PasswordRepeatInput.Text)
            {
                InfoText.Text +=  $"{ExepPasswordRepeat}{NewLine}";
                tmp = false;
            }

            return tmp;
        }

        private void EmailSend(string user, string email)
        {
            try
            {
                MailMessage mail = new()
                {
                    From = new MailAddress(email),
                    Subject = $"{Defines.Registration}",
                    Body = $"{Welcome}{Gap}{user}"
                };
                SmtpClient client = new()
                {
                    Host = Host,
                    Port = Port,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(Email, Password)
                };
                client.Send(mail);
            }
            catch (FormatException)
            {
                MessageBox.Show($"{Defines.FormatException}");
                
            }
            catch (ArgumentException)
            {
                MessageBox.Show($"{Defines.ArgumentException}");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}{NewLine}{ExeptionEx}");
            }
        }
    }
}