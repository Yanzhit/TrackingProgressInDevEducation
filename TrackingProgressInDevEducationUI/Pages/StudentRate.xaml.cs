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
    /// Interaction logic for StudentRate.xaml
    /// </summary>
    public partial class StudentRate : Page
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
        public StudentRate()
        {
            InitializeComponent();
        }
        

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }
    }
}
