using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TrackingProgressInDevEducationBLL;
using TrackingProgressInDevEducationBLL.Facades.ForTables;
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
                students = FacadeStudent.GetStudents();
                foreach (var student in students)
                {
                    RequestViewTextBox.Text += $"{student.Name} {student.Surname} {student.Rate}\n";
                }
            }

            if (GetStudentsByIdRadioButton.IsChecked == true)
            {
                //queries = new Queries(Int32.Parse(GetStudentsByIdTextBoxId.Text));
                //students = (List<QStudent>)QuerySettings.QuerySet(queries.GetByIdStudent);
                //foreach (QStudent student in students)  
                //{
                //    RequestViewTextBox.Text += $"{student.Name} {student.Surname} {student.Rate}\n";
                //}
            }
        }
        
    }
}
