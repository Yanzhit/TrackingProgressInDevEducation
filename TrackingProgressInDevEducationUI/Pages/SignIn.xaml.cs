using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
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
        private readonly SingleContents _contents = SingleContents.GetContent();
        private readonly FacadeManager _manager = new();
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            Lector lector = _manager.Lectors.GetLoginAndPassword(Login.Text, Password.Text);
            _contents.Home();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            _contents.Registration();
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            //Нужно добавить информацию о приложении
        }
    }
}
