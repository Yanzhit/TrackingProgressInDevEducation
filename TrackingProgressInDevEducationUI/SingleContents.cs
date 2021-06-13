using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationUI.Pages;
using TrackingProgressInDevEducationUI.Pages.Secondary;
using TrackingProgressInDevEducationUI.Windows;
using Course = TrackingProgressInDevEducationUI.Pages.Course;
using Group = TrackingProgressInDevEducationUI.Pages.Group;
using static TrackingProgressInDevEducationUI.Defines;

namespace TrackingProgressInDevEducationUI
{
    public class SingleContents
    {
        public GetLectorA Lector { get; set; }
        public SetGroupA NewGroup{ get; set; }
        //public SetGroupA NewTeam{ get; set; }
        public OperationLogics OperationLogics { get; set; } = new OperationLogics();
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
        private AdditionalWindows _additionalWindows;
        private AddStudentToGroup _addStudentToGroup;
        private AddStudentToTeams _addStudentToTeams;

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
       
        public void GroupJournal(int id)
        {
            _groupJournal = new GroupJournal(id);
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
        
        public void WinNewGroup()
        {
            _additionalWindows = new AdditionalWindows() { Title = NewGroupT, Width = NewGroupW, Height = NewGroupH };
            _group = new Group();
            _additionalWindows.Content = _group;
            _additionalWindows.ShowDialog();
        }
        public void WinNewTeam()
        {
            _additionalWindows = new AdditionalWindows() { Title = NewTeamT, Width = NewTeamW, Height = NewTeamH };
            _createTeam = new CreateTeam();
            _additionalWindows.Content = _createTeam;
            _additionalWindows.ShowDialog();
        }

        public void WinStudentToGroup()
        {
            _additionalWindows = new AdditionalWindows(){Title = AddStudentToGroupT, Width = AddStudentToGroupW, Height = AddStudentToGroupH};
            _addStudentToGroup = new AddStudentToGroup();
            _additionalWindows.Content = _addStudentToGroup;
            _additionalWindows.ShowDialog();
        }
        
        public void WinStudentToTeam()
        {
            _additionalWindows = new AdditionalWindows() { Title = StudentToTeamT, Width = StudentToTeamW, Height = StudentToTeamH };
            _addStudentToTeams = new AddStudentToTeams();
            _additionalWindows.Content = _addStudentToGroup;
            _additionalWindows.ShowDialog();
        }

        public void CloseAdditionalWindows()
        {
            _additionalWindows.Close();
        }
    }
}