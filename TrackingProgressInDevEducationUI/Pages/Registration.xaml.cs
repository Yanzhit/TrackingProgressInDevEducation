using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using static TrackingProgressInDevEducationUI.Defines;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private int _key;
        private readonly FacadeManager _manager = new();
        private Dictionary<string, string> _param;
        public Registration()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            //_mainForm.Content = signIn;
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            bool isRegistration = Verification();
            if (isRegistration)
            {
                WriteParams();
                NewUser();
            }
        }

        private void NewUser()
        {
            Lector lector = _manager.Lectors.SetNewLector(_param["Name"], _param["Email"], _param["Password"]);
            if (lector.FullName == _param["Name"]
                && lector.Email == _param["Name"]
                && lector.Password == _param["Password"])
            {
                int key = GenerateKey();
                bool send = EmailSend(key);
                if (send)
                {
                    _key = key;
                    
 
                }
            }
        }

        private int GenerateKey()
        {
            Random random = new();
            return random.Next(1000, 9999);
        }

        private void WriteParams()
        {
            _param = new Dictionary<string, string>
            {
                {"Name", FullNameInput.Text}, {"Email", EmailInput.Text}, {"Password", PasswordInput.Text}
            };
        }

        private bool Verification()
        {
            var tmp = true;
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

        private bool EmailSend(int key)
        {
            bool send = true;
            try
            {
                MailMessage mail = new()
                {
                    From = new MailAddress(From),
                    Subject = $"{Defines.Registration}",
                    Body = $"{Welcome}{Gap}{_param["Name"]}{NewLine}{VerifyRegistr}{Gap}{key}"
                };
                mail.To.Add(_param["Email"]);
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
                send = false;
                
            }
            catch (ArgumentException)
            {
                MessageBox.Show($"{Defines.ArgumentException}");
                send = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{NewLine}{ExeptionEx}");
                send = false;
            }

            return send;
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            SingleContents.GetContent().SignIn();
        }

        private void CheckKey_Click(object sender, RoutedEventArgs e)
        {
            if (_key == Convert.ToInt32(InputKey.Text))
            {
                MessageBox.Show(Congratulation);
                SingleContents.GetContent().SignIn();
            }
        }
    }
}