using System;
using TrackingProgressInDevEducationUI.Pages;
using TrackingProgressInDevEducationUI.Pages.TestsPages;

namespace TrackingProgressInDevEducationUI
{
    public class SingleContents
    {
        private static SingleContents _contents;
        private readonly MainForm _main;
        private Course _course;
        private Group _group;
        private Home _home;
        private NewStudent _newStudent;
        private Registration _registration;
        private SignIn _signIn;
        private Student _student;
        private Students _students;


        private MainMenu _mainMenu;
        private QueriesTests _queriesTests;


        private SingleContents()
        {
            _main = new();
        }

        public SingleContents GetContent()
        {
            return _contents ??= new SingleContents();
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

        public void MainMenu()
        {
            _mainMenu ??= new MainMenu();
            _main.Content = _mainMenu;
        }
        public void QueriesTests()
        {
            _queriesTests ??= new QueriesTests();
            _main.Content = _queriesTests;
        }
    }
}