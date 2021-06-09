using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using TrackingProgressInDevEducationBLL;
using TrackingProgressInDevEducationBLL.Models.Group;
/*
SetNewGroups
GetAllCurses
*/
namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for Group.xaml
    /// </summary>
    public partial class Group : Page
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
        public Group()
        {
            InitializeComponent();
            GetAllCursesInPage();
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.Home();
        }

        private void BCreatGroup_Click(object sender, RoutedEventArgs e)
        {
            OperationLogics operation = new OperationLogics();
            var setNewGroup = operation.SetNewGroup(new SetGroupQ(TBGroupName.Text, CBChangeCourse.SelectedIndex+1, DPStartDate.Text, DPEndDate.Text));
            MessageBox.Show("Группа"+" "+ TBGroupName.Text+" Созданна!");
        }

        private void CBChangeCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void GetAllCursesInPage()
        {
            OperationLogics operation = new OperationLogics();
            List<SetCoursesA> getAllCurses = operation.GetAllCurses(new SetCoursesQ());
            foreach (var course in getAllCurses)
            {
                CBChangeCourse.Items.Add(course.Name);
            }
        }
    }
}
