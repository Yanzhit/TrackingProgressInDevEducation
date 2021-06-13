using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using TrackingProgressInDevEducationBLL;
using TrackingProgressInDevEducationBLL.Models.Registration;
using static TrackingProgressInDevEducationUI.Defines;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
        private readonly OperationLogics _operation = new OperationLogics();
        private Dictionary<string, string> _param;
        public Registration()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            _contents.SignIn();
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
            var query = new SetLectorQ(_param["Login"], _param["FullName"], _param["Email"],  _param["Password"]);

            SetLectorA answer = _operation.SetNewLector(query);

            if (answer.Login == _param["Login"]
                && answer.FullName == _param["FullName"]
                && answer.Email == _param["Email"]
                && answer.Password == _param["Password"])
            {
                SmtpService service = new();
                int key = service.SmtpRun(_param);
                if (key != -1)
                {
                    _contents.Verification(key, answer.Id);
                }
            }
        }

        private void WriteParams()
        {
            _param = new Dictionary<string, string>
            {
                {"Login", LoginInput.Text},
                {"FullName", FullNameInput.Text},
                {"Email", EmailInput.Text},
                {"Password", PasswordInput.Text}
            };
        }

        private bool Verification()
        {
            var tmp = true;
            if (FullNameInput.Text.Length is < FullNameCharMin or > FullNameCharMax)
            {
                InfoText.Text = $"{ExcepFNameLength}{NewLine}";
                tmp = false;
            }

            if (LoginInput.Text.Length is < LoginCharMin or > LoginCharMax)
            {
                InfoText.Text = $"{ExcepFNameLength}{NewLine}";
                tmp = false;
            }

            if (EmailInput.Text.Length is < EmailCharMin or > EmailCharMax)
            {
                InfoText.Text =  $"{ExcepEmailLength}{NewLine}";
                tmp = false;
            }

            if (PasswordInput.Text.Length is < PasswordCharMin or > PasswordCharMax)
            {
                InfoText.Text =  $"{ExcepPasswordLength}{NewLine}";
                tmp = false;
            }

            if (PasswordInput.Text != PasswordRepeatInput.Text)
            {
                InfoText.Text =  $"{ExcepPasswordRepeat}{NewLine}";
                tmp = false;
            }
            return tmp;
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.SignIn();
        }
    }
}