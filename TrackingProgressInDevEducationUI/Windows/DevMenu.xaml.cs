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
using TrackingProgressInDevEducationBLL.Models.Bases;
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
            _contents.Course();
        }

        private void CreateTeam_Click(object sender, RoutedEventArgs e)
        {
            _contents.CreateTeam();
        }

        private void Group_Click(object sender, RoutedEventArgs e)
        {
            _contents.Group();
        }

        private void GroupInfo_Click(object sender, RoutedEventArgs e)
        {
            _contents.GroupInfo();
        }

        private void GroupJournal_Click(object sender, RoutedEventArgs e)
        {
            _contents.GroupJournal();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            _contents.Home();
        }

        private void MyProfile_Click(object sender, RoutedEventArgs e)
        {
            _contents.MyProfile();
        }

        private void NewStudent_Click(object sender, RoutedEventArgs e)
        {
            _contents.NewStudent();
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
            _contents.TeamInfo();
        }

        private void TeamRate_Click(object sender, RoutedEventArgs e)
        {
            _contents.TeamRate();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OperationLogics operation = new OperationLogics();
            var sss =operation.GetLectorByLoginAndPassword(new QGetLector("Kozlov.s.v.1992@gmail.com",""));
        }
    }
}