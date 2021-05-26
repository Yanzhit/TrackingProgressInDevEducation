using System.Windows;
using System.Windows.Controls;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        private readonly MainForm _mainForm;
        public SignIn(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            MainMenu menu = new MainMenu(_mainForm);
            _mainForm.Content = menu;
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration(_mainForm);
            _mainForm.Content = registration;
        }
    }
}
