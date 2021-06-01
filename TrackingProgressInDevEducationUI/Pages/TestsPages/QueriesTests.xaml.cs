using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationUI.Pages.TestsPages
{
    /// <summary>
    /// Логика взаимодействия для QueriesTests.xaml
    /// </summary>
    public partial class QueriesTests : Page
    {
        private MainForm _mainForm;
        public QueriesTests(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void SendQueries_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Student> students;
            if (GetStudentsRadioButton.IsChecked == true)
            {
                students = Students.GetStudents();
                foreach (var student in students)
                {
                    RequestViewTextBox.Text += $"{student.Name} {student.Surname} {student.Rate}\n";
                }
            }

            if (GetStudentsByIdRadioButton.IsChecked == true)
            {
                //Student sss = FacadeStudent.GetByIdStudent(1);
                //RequestViewTextBox.Text += $"{sss.Name} {sss.Surname} {sss.Rate}\n";
            }
        }
    }
}
