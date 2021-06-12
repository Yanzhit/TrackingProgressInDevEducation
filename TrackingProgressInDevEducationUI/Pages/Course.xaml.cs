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
using TrackingProgressInDevEducationBLL.Models.Group;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для Course.xaml
    /// </summary>
    public partial class Course : Page
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
        public Course()
        {
            InitializeComponent();
            GetAllCursesInPage();
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

        private void BCreateCurses_Click(object sender, RoutedEventArgs e)
        {
            OperationLogics operation = new OperationLogics();
            var setNewCourses = operation.SetNewCourse(new SetNewCoursesQ(TBNameCurses.Text, TBCourseDescription.Text));
            MessageBox.Show("Курс " + TBNameCurses.Text + " Созданн!");
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

        private void TBNameCurses_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
