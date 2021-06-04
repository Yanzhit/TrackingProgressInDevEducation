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
        private readonly FacadeManager _manager = new();
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            Lector lector = _manager.Lectors.GetLoginAndPassword(Login.Text, Password.Text);
            
           // _mainForm.Content = home;
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            //_mainForm.Content = registration;
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
