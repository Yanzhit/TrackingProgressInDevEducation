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
using TrackingProgressInDevEducationBLL.Models.Comment;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for StudentProfile.xaml
    /// </summary>
    public partial class StudentProfile : Page
    {
        private readonly OperationLogics _operation = new();
        private readonly SingleContents _contents = SingleContents.GetContent();
        
        public StudentProfile(int studentId = 10, int commentType = 1, int commentFor = 2)
        {
            InitializeComponent();
            WriteTable(studentId, commentType, commentFor);
        }
        private void NameGroup(string name)
        {
            LPageName.Content = name;
        }
        private void WriteTable(int studentId, int commentType, int commentFor)
        {
            TableStudent(studentId, commentType, commentFor);
        }

        private void TableStudent(int studentId, int commentType, int commentFor)
        {
            GetCommentsByStudentA.ItemsSource = RenderGroup(studentId, commentType, commentFor);
        }

        private IEnumerable<GetCommentsByStudentA> RenderGroup(int studentId, int commentType, int commentFor)
        {
            var query = new GetCommentsByStudentQ(studentId, commentType, commentFor);
            return _operation.GetCommentsByStudent(query);
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _contents.StudentRate();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
