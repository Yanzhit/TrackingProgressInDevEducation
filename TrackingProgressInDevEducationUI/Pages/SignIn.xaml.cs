using System.Windows;
using System.Windows.Controls;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    // ReSharper disable once RedundantExtendsListEntry
    public partial class SignIn : Page
    {
        private readonly MainForm _mainForm;
        private readonly FacadeManager _manager = new();
        public SignIn(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            Lector lector = _manager.Lectors.GetLoginAndPassword(Login.Text, Password.Text);
            HomePage home = new(_mainForm, lector.FullName);
            _mainForm.Content = home;
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new(_mainForm);
            _mainForm.Content = registration;
        }
    }
}
