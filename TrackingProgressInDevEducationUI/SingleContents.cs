using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationUI.Pages;
using TrackingProgressInDevEducationUI.Windows;
using Course = TrackingProgressInDevEducationUI.Pages.Course;
using Group = TrackingProgressInDevEducationUI.Pages.Group;
using Student = TrackingProgressInDevEducationUI.Pages.Student;

namespace TrackingProgressInDevEducationUI
{
    public class SingleContents
    {
        private static SingleContents _contents;
        private readonly MainForm _main;
        private Verification _verification;
        private Course _course;
        private Group _group;
        private Home _home;
        private NewStudent _newStudent;
        private Registration _registration;
        private SignIn _signIn;
        private Student _student;
        private Students _students;
        private AddStudentsToTeam _addStudentsToTeam;
        private GroupInfo _groupInfo;

        private SingleContents()
        {// A recipient must be specified
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
            return _contents ??= new SingleContents(main);
        }
        public void Course()
        {
            _course ??= new Course();
            _main.Content = _course;
        }

        public void Group()
        {
            _group ??= new Group();
            _main.Content = _group;
        }
        public void Home()
        {
            _home ??= new Home();
            _main.Content = _home;
        }
        public void Home(Lector lector)
        {
            _home = new Home(lector);
            _main.Content = _home;
        }

        public void NewStudent()
        {
            _newStudent ??= new NewStudent();
            _main.Content = _newStudent;
        }


        public void Registration()
        {
            _registration ??= new Registration();
            _main.Content = _registration;
        }

        public void SignIn()
        {
            _signIn ??= new SignIn();
            _main.Content = _signIn;
        }

        public void Student()
        {
            _student ??= new Student();
            _main.Content = _student;
        }

        public void Students()
        {
            _students ??= new Students();
            _main.Content = _students;
        }
        
        public void AddStudentsToTeam()
        {
            _addStudentsToTeam ??= new AddStudentsToTeam();
            _main.Content = _addStudentsToTeam;
        }
        
        public void GroupInfo()
        {
            _groupInfo ??= new GroupInfo();
            _main.Content = _groupInfo;
        }

        public void Verification(int key, int id)
        {
            _verification = new Verification(key, id);
            _verification.Show();
        }
    }
}