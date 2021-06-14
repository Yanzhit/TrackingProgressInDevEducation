using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TrackingProgressInDevEducationBLL;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationUI.Windows
{
    /// <summary>
    /// Логика взаимодействия для DevMenu.xaml
    /// </summary>
    public partial class DevMenu : Window
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
        public DevMenu()
        {
            InitializeComponent();
        }

        private void AddStudentsToGroup_Click(object sender, RoutedEventArgs e)
        {
            _contents.AddStudentsToGroup();
        }

        private void AddStudentsToTeam_Click(object sender, RoutedEventArgs e)
        {
            _contents.AddStudentsToTeam();
        }

        private void Course_Click(object sender, RoutedEventArgs e)
        {
            _contents.WinNewCourse();
        }

        private void CreateTeam_Click(object sender, RoutedEventArgs e)
        {
            _contents.WinNewTeam();
        }

        private void Group_Click(object sender, RoutedEventArgs e)
        {
            _contents.WinNewGroup();
        }

        private void GroupInfo_Click(object sender, RoutedEventArgs e)
        {
            _contents.GroupInfo(2);
        }

        private void GroupJournal_Click(object sender, RoutedEventArgs e)
        {
            _contents.GroupJournal(2);
        }

        private void MyProfile_Click(object sender, RoutedEventArgs e)
        {
            _contents.MyProfile();
        }

        private void NewStudent_Click(object sender, RoutedEventArgs e)
        {
            _contents.WinNewStudent();
            _contents.CloseAdditionalWindows();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            _contents.Registration();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            _contents.SignIn();
        }

        private void StudentProfile_Click(object sender, RoutedEventArgs e)
        {
            _contents.StudentProfile();
        }

        private void StudentRate_Click(object sender, RoutedEventArgs e)
        {
            _contents.StudentRate();
        }

        private void Students_Click(object sender, RoutedEventArgs e)
        {
            _contents.Students();
        }

        private void TeamInfo_Click(object sender, RoutedEventArgs e)
        {
            _contents.TeamInfo(2, "22");
        }
        
        private void MainPage_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

        private void TeamRate_Click(object sender, RoutedEventArgs e)
        {
            _contents.TeamRate();
        }
    }
}