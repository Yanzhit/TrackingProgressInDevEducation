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

        public GroupInfo(int id = 2)
        {
            InitializeComponent();
            WriteTable(id);
        }

        private void NameGroup(string name)
        {
            LPageName.Content = name;
        }
        private void WriteTable(int id)
        {
            TableCourses(id);
            TableStudent(id);
        }
        private void TableCourses(int id)
        {
            //GetGroupByIdJA.Items.Add(RenderCourse(id));
        }
        private void TableStudent(int id)
        {
            GetAllStudentsByGroupA.ItemsSource = RenderGroup(id);
        }
        private IEnumerable<GetAllStudentsByGroupA> RenderGroup(int id)
        {
            var query = new GetAllStudentsByGroupQ(id);
            return _operation.GetAllStudentsByGroup(query);
        }
        //private GetGroupByIdJA RenderCourse(int id)
        //{
        //    var query = new GetGroupByIdJQ(id);
        //    var result =  _operation.GetGroupByIdJ(query);
        //    NameGroup(result.NameG);
        //    return result;
        //}

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
    }
}
