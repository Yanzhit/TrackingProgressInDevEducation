using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using TrackingProgressInDevEducationBLL;
using TrackingProgressInDevEducationBLL.Models.GroupInfo;
using TrackingProgressInDevEducationBLL.Models.GroupJournal;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for GroupJournal.xaml
    /// </summary>
    public partial class GroupJournal : Page
    {
        private DataTable _dT;
        private readonly OperationLogics _operation = new();
        private readonly SingleContents _contents = SingleContents.GetContent();
        public GroupJournal(int id = 2)
        {
            InitializeComponent();
            InitialisationDT();
            WriteData(id);
            
        }

        private void InitialisationDT()
        {
            _dT = new DataTable();
        }

        private void WriteData(int id)
        {
            List<GetAllStudentsByGroupA> students = WriteDGridStudents(id);
            var visits = _operation.GetVisitsByStudentJ(new GetVisitsByStudentJQ(students[0].Id));
            PreparingDGVisitsColumm(visits);

            foreach (var student in students)
            {
                var visit = _operation.GetVisitsByStudentJ(new GetVisitsByStudentJQ(student.Id));
                PreparingDGVisitsRows(visit, $"{student.Surname} {student.Name}");
            }

            DGVisits.ItemsSource = _dT.DefaultView;
        }

        private void PreparingDGVisitsRows(List<GetVisitsByStudentJA> ttt, string fullName)
        {
            DataRow name = _dT.NewRow();
            name[0] = fullName;
            for (var i = 1; i <= ttt.Count; i++)
            {
                name[i] = ttt[i-1].VisitStatus;
            }
            _dT.Rows.Add(name);
        }


        private void PreparingDGVisitsColumm(List<GetVisitsByStudentJA> ttt)
        {
            var name = new DataColumn("Студенты", typeof(string));
            _dT.Columns.Add(name);
            foreach (var t in ttt)
            {
                var column = new DataColumn(t.StartedOn, typeof(bool));
                _dT.Columns.Add(column);
            }
        }


        private List<GetAllStudentsByGroupA> WriteDGridStudents(int id)
        {
            var student = _operation.GetAllStudentsByGroup(new GetAllStudentsByGroupQ(id));
            //DGStudents.ItemsSource = student;
            return student;
        }


        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

    }
}
