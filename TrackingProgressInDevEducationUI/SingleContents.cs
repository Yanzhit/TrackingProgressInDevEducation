using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationUI.Pages;
using TrackingProgressInDevEducationUI.Windows;
using Course = TrackingProgressInDevEducationUI.Pages.Course;
using Group = TrackingProgressInDevEducationUI.Pages.Group;

namespace TrackingProgressInDevEducationUI
{
    public class SingleContents
    {
        public GetLectorA Lector;
        private static SingleContents _contents;
        private readonly MainForm _main;
        private AddStudentsToGroup _addStudentsToGroup;
        private AddStudentsToTeam _addStudentsToTeam;
        private Course _course;
        private CreateTeam _createTeam;
        private Group _group;
        private GroupInfo _groupInfo;
        private GroupJournal _groupJournal;
        private MyProfile _myProfile;
        private NewStudent _newStudent;
        private Registration _registration;
        private SignIn _signIn;
        private StudentProfile _studentProfile;
        private StudentRate _studentRate;
        private Students _students;
        private TeamInfo _teamInfo;
        private TeamRate _teamRate;
        private MainPage _mainPage;
        private Verification _verification;
        private DevMenu _devMenu;

        private SingleContents()
        {
        }
        private SingleContents(MainForm main)
        {
            _main = main;
        }
        public static SingleContents GetContent()
        {
            return _contents ??= new SingleContents();
        }
        public static SingleContents SetForm(MainForm main)
        {
            return _contents = new SingleContents(main);
        }
        public void Course()
        {
            _course = new Course();
            _main.Content = _course;
        }

        public void Group()
        {
            _group = new Group();
            _main.Content = _group;
        }

        public void MainPage()
        {
            _mainPage = new MainPage();
            _main.Content = _mainPage;
        }

        public void MainPage(GetLectorA lector)
        {
            Lector = lector;
            _mainPage = new MainPage();
            _main.Content = _mainPage;
        }

        public void NewStudent()
        {
            _newStudent = new NewStudent();
            _main.Content = _newStudent;
        }


        public void Registration()
        {
            _registration = new Registration();
            _main.Content = _registration;
        }

        public void SignIn()
        {
            _signIn = new SignIn();
            _main.Content = _signIn;
        }

        public void Students()
        {
            _students = new Students();
            _main.Content = _students;
        }

        public void AddStudentsToTeam()
        {
            _addStudentsToTeam = new AddStudentsToTeam();
            _main.Content = _addStudentsToTeam;
        }

        public void GroupInfo()
        {
            _groupInfo = new GroupInfo();
            _main.Content = _groupInfo;
        }

        public void Verification(int key, int id)
        {
            _verification = new Verification(key, id);
            _verification.ShowDialog();
        }
        public void AddStudentsToGroup()
        {
            _addStudentsToGroup = new AddStudentsToGroup();
            _main.Content = _addStudentsToGroup;
        }
        public void CreateTeam()
        {
            _createTeam = new CreateTeam();
            _main.Content = _createTeam;
        }
        public void GroupJournal()
        {
            _groupJournal = new GroupJournal();
            _main.Content = _groupJournal;
        }
        public void MyProfile()
        {
            _myProfile = new MyProfile();
            _main.Content = _myProfile;
        }
        public void StudentProfile()
        {
            _studentProfile = new StudentProfile();
            _main.Content = _studentProfile;
        }
        public void StudentRate()
        {
            _studentRate = new StudentRate();
            _main.Content = _studentRate;
        }
        public void TeamInfo()
        {
            _teamInfo = new TeamInfo();
            _main.Content = _teamInfo;
        }
        public void TeamRate()
        {
            _teamRate = new TeamRate();
            _main.Content = _teamRate;
        }
        public void DevMenu()
        {
            _devMenu = new DevMenu();
            _devMenu.Show();
        }
    }
}