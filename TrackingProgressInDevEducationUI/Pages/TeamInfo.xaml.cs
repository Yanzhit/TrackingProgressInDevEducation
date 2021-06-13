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
    /// Interaction logic for TeamInfo.xaml
    /// </summary>
    public partial class TeamInfo : Page
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
        public TeamInfo()
        {
            InitializeComponent();
        }
        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

        private void BAddComment_Click(object sender, RoutedEventArgs e)
        {
            _contents.TeamRate();
        }

        private void BAddStudents_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
