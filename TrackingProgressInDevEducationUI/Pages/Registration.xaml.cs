using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using static TrackingProgressInDevEducationUI.Defines;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
       // private readonly DALManager _manager = new();
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
           // Lector lector = _manager.Lectors.SetNewLector(_param["FullName"], _param["Email"],  _param["Password"]);
            //if (lector.FullName == _param["FullName"]
            //    && lector.Email == _param["Email"]
            //    && lector.Password == _param["Password"])
            //{
            //    SmtpService service = new();
            //    int key = service.SmtpRun(_param);
            //    if (key != -1)
            //    {
            //        SingleContents.GetContent().Verification(key, lector.Id);
            //    }
            //}
        }

        private void WriteParams()
        {
            _param = new Dictionary<string, string>
            {
                {"FullName", FullNameInput.Text},
                {"Email", EmailInput.Text},
                {"Password", PasswordInput.Text}
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

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.Home();
        }
    }
}