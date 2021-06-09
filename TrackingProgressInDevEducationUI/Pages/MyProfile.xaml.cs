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
    /// Interaction logic for MyProfile.xaml
    /// </summary>
    public partial class MyProfile : Page
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
        public MyProfile()
        {
            InitializeComponent();
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.Home();
        }

        private void BAddCourse_Click(object sender, RoutedEventArgs e)
        {
            _contents.Course();
        }

        private void BLogout_Click(object sender, RoutedEventArgs e)
        {
            _contents.Lector = null;
            _contents.SignIn();
        }

        private void BChangePassword_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
