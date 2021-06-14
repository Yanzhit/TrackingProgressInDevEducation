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
using TrackingProgressInDevEducationBLL;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.Students;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for Students.xaml
    /// </summary>
    public partial class Students : Page
    {
        private readonly OperationLogics _operation = new();
        private readonly SingleContents _contents = SingleContents.GetContent();
        public Students()
        {
            InitializeComponent();
            WriteGrids();
        }

        private void StudentGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

        private void WriteGrids()
        {
            var www = RenderStudents();
            //DGStudent.ItemsSource = 
        }

        private IEnumerable<GetAllStudentsA> RenderStudents()
        {
            return _operation.GetAllStudents(new EmptyQ());
        }

        private void BAddStudent_Click(object sender, RoutedEventArgs e)
        {
            _contents.WinNewStudent();
        }
    }
}