using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
            if (GetStudentsByIdRadioButton.IsChecked == true)
            {
                Queryes queryes = new Queryes();
                object objects = QuerySettings.Connect(queryes.GetStudents);
                List<Students> students = (List<Students>)objects;
                foreach (Students student in students)
                {
                    RequestViewTextBox.Text += $"{student.Name} {student.Surname} {student.Rate}\n";
                }
            }
        }
    }
}
