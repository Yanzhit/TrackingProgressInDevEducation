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
using TrackingProgressInDevEducationBLL.Models.GroupInfo;
using TrackingProgressInDevEducationBLL.Models.MainPage;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// 
    /// GetAllStudentsByGroup
    /// </summary>
    public partial class GroupInfo : Page
    {
        private readonly OperationLogics _operation = new();
        private readonly SingleContents _contents = SingleContents.GetContent();

        public GroupInfo()
        {
            InitializeComponent();
            NameGroup();
            WriteTable();
        }

        private void NameGroup()
        {
            LPageName.Content = $"ghfghfgh";
        }
        private void WriteTable()
        {
            TableCourses();
            TableStudent();
        }
        private void TableCourses()
        {

        }
        private void TableStudent()
        {
            GetAllStudentsByGroupA.ItemsSource = RenderGroup();
        }
        private IEnumerable<GetAllStudentsByGroupA> RenderGroup()
        {
            var query = new GetAllStudentsByGroupQ(2/*нужно апракинуть группу*/);
            return _operation.GetAllStudentsByGroup(query);
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

        private void BAddStudent_Click(object sender, RoutedEventArgs e)
        {
            _contents.AddStudentsToGroup();
        }

        private void BJournal_Click(object sender, RoutedEventArgs e)
        {
            _contents.GroupJournal();
        }

        private void DGGroupInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
