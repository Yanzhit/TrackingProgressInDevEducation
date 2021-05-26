using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private MainForm _mainForm;
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
            if (NameInput.Text.Length is <= 0 or > 50 ||
                SurnameInput.Text.Length is <= 0 or > 50 ||
                PasswordInput.Text.Length is <= 0 or > 50 ||
                PasswordRepeatInput.Text.Length is <= 0 or > 50 ||
                PasswordInput.Text != PasswordRepeatInput.Text)
            {

            }
            //if(SurnameInput.Text.Length is <= 0 or > 50)
            //{
                
            //}
            //if (PasswordInput.Text.Length is <= 0 or > 50)
            //{

            //}
            //if (PasswordRepeatInput.Text.Length is <= 0 or > 50)
            //{

            //}
            //if (PasswordInput.Text != PasswordRepeatInput.Text)
            //{

            //}
        }
    }
}
