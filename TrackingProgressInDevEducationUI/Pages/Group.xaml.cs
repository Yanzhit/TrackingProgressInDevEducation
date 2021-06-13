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
            _contents.MainPage();
        }

        private void BCreatGroup_Click(object sender, RoutedEventArgs e)
        {
            _contents.NewGroup = _contents.OperationLogics.SetNewGroup(new SetGroupQ()
            {
                GroupId = null,
                LectorId = _contents.Lector.Id,
                CourseId = CBChangeCourse.SelectedIndex + 1,
                Name = TBGroupName.Text,
                StartDate = DPStartDate.Text,
                EndDate = DPEndDate.Text
            });

            _contents.CloseAdditionalWindows();
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
            CBChangeCourse.SelectedIndex = 0;
        }
    }
}
