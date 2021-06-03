using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.BLLModels.Bases;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationUI.Pages.TestsPages
{
    /// <summary>
    /// Логика взаимодействия для QueriesTests.xaml
    /// </summary>
    public partial class QueriesTests : Page
    {
        private MainForm _mainForm;
        public City tCity;
        public QueriesTests(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            tCity = new City("Вологдар");
        }

        private void SendQueries_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Student> students;
            if (GetStudentsRadioButton.IsChecked == true)
            {
                FacadeManager f = new FacadeManager();
                students = f.Students.GetAllStudents();
                foreach (var student in students)
                {
                    RequestViewTextBox.Text += $"{student.Name} {student.Surname} {student.Rate}\n";
                }
            }

            if (GetStudentsByIdRadioButton.IsChecked == true)
            {
                //Student sss = FacadeStudent.GetByIdStudent(1);
                //RequestViewTextBox.Text += $"{sss.Name} {sss.Surname} {sss.Rate}\n";
                //
                //BCity tBCity = new BCity(tCity);
                FacadeManager f = new FacadeManager();
                Comment city = f.Comments.SetNewComment("Привет", 1, 1, 1, 1);
                RequestViewTextBox.Text += $"{city.Text}";
            }
        }
    }
}
