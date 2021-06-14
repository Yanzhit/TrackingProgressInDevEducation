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
        private int _id;
        private string _name;
        private readonly SingleContents _contents = SingleContents.GetContent();
        public TeamInfo(int id, string name)
        {
            InitializeComponent();
            _id = id;
            _name = name;
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
