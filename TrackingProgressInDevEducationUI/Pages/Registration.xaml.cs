using System.Windows;
using System.Windows.Controls;
using TrackingProgressInDevEducationBLL.Facades.ForTables;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private readonly MainForm _mainForm;
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
            if (FullName_Input.Text.Length is <= 0 or > 50)
            {
                return;
            }

            if (Email_Input.Text.Length is <= 0 or > 50)
            {
                return;
            }

            if (Password_Input.Text.Length is <= 0 or > 50)
            {
                return;
            }

            if (PasswordRepeat_Input.Text.Length is <= 0 or > 50)
            {
                return;
            }

            if (Password_Input.Text == PasswordRepeat_Input.Text)
            {
                FacadeLectors.SetNewLector(FullName_Input.Text, Email_Input.Text, Password_Input.Text);
            }
        }
    }
}
