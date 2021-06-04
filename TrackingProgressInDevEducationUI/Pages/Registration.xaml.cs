using System;
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
            SignIn signIn = new SignIn(_mainForm);
            _mainForm.Content = signIn;
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            if (Password_Input.Text == PasswordRepeat_Input.Text)
            {

            }
            Registrations();
        }

        private void Registrations()
        {
            try
            {
                string user = "Станислав";
                var mail = new MailMessage {From = new MailAddress("EducationCore@yandex.ru")};
                mail.To.Add(new MailAddress("educationcore@mail.ru"));
                mail.Subject = $"{Defines.Registration}";
                mail.Body = $"{Welcome}{Gap}{user}";

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