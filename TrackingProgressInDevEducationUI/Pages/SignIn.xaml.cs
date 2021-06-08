using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TrackingProgressInDevEducationBLL;
using TrackingProgressInDevEducationBLL.Models.Bases;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using static TrackingProgressInDevEducationUI.Defines;
using MessageBox = System.Windows.Forms.MessageBox;
using MessageBoxOptions = System.Windows.Forms.MessageBoxOptions;

//using TrackingProgressInDevEducationDAL;
//using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для SignIns.xaml
    /// </summary>
    // ReSharper disable once RedundantExtendsListEntry
    public partial class SignIn : Page
    {
        private readonly OperationLogics _operation = new();
        private readonly SingleContents _contents = SingleContents.GetContent();
        //private readonly DALManager _manager = new();
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            var query = new GetLectorQ(Login.Text, Password.Text);
            GetLectorA answer = _operation.GetLectorByLoginAndPassword(query);
            if (answer != null)
            {
                if (answer.IsActivated)
                {
                    _contents.Home(answer);
                }
                else
                {
                    CheckActive(answer);
                }
            }
            else
            {
                Info.Text = $"{ExcepEntrance}";
            }
        }

        private void CheckActive(GetLectorA answer)
        {
            DialogResult result = MessageBox.Show
            (
                $"{NoActive}",
                $"{Warning}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
            );

            if (result == DialogResult.Yes)
            {
                Activated(answer);
            }
            else
            {
                MessageBox.Show($"{Warning1}" +
                                $"{Warning2}");
                MessageBox.Show($"{ErrorActive}" +
                                $"{ErrorActive1}{Email}{NewLine}" +
                                $"{ErrorActive2}");
            }
        }

        private void Activated(GetLectorA answer)
        {
            SmtpService service = new();
            var param = new Dictionary<string, string>
            {
                {"FullName", answer.FullName},
                {"Email", answer.Email}
            };
            int key = service.SmtpRun(param);
            _contents.Verification(key, answer.Id);
        }


        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            _contents.Registration();
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            //Нужно добавить информацию о приложении
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _contents.DevMenu();
        }
    }
}
