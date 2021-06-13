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

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// 
    /// GetAllStudentsByGroup
    /// </summary>
    public partial class GroupInfo : Page
    {
        private int _id;
        private readonly OperationLogics _operation = new();
        private readonly SingleContents _contents = SingleContents.GetContent();

        public GroupInfo(int id)
        {
            InitializeComponent();
            _id = id;
            WriteTable();
        }

        private void NameGroup(string name)
        {
            LPageName.Content = name;
        }
        private void WriteTable()
        {
            TableCourses();
            TableStudent();
        }
        private void TableCourses()
        {
            //GetGroupByIdJA.Items.Add(RenderCourse(_id));
        }
        private void TableStudent()
        {
            GetAllStudentsByGroupA.ItemsSource = RenderGroup();
        }
        private IEnumerable<GetAllStudentsByGroupA> RenderGroup()
        {
            var query = new GetAllStudentsByGroupQ(_id);
            return _operation.GetAllStudentsByGroup(query);
        }
        //private GetGroupByIdJA RenderCourse()
        //{
        //    var query = new GetGroupByIdJQ(_id);
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
            _contents.GroupJournal(_id);
        } 
    }
}
