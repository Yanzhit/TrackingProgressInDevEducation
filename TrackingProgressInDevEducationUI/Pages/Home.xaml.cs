using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using static TrackingProgressInDevEducationUI.Defines;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : PageFunction<String>
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
        
        //private AGetLector _lector;
        public Home()
        {
            InitializeComponent();
            Welcome();
        }

        private void Welcome()
        {
            WelcomeBlock.Text = $"{Welcome2}{Sep}{_contents.Lector}";
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.SignIn();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _contents.Group();
        }

        private void WelcomeBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            _contents.MyProfile();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _contents.Students();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _contents.GroupJournal();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _contents.CreateTeam();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            _contents.TeamInfo();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            _contents.GroupInfo();
        }
    }
}
