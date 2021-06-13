using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
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
        private readonly Dictionary<string, int> _dictionary = new();
        private DataTable _dT;
        private readonly OperationLogics _operation = new();
        private readonly SingleContents _contents = SingleContents.GetContent();
        public GroupJournal(int id)
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
            if (students.Count != 0)
            {
                var visits = _operation.GetVisitsByStudentJ(new GetVisitsByStudentJQ(students[0].Id));
                PreparingDGVisitsColumm(visits);
                int key = 0;
                foreach (var student in students)
                {
                    var visit = _operation.GetVisitsByStudentJ(new GetVisitsByStudentJQ(student.Id));
                    PreparingDGVisitsRows(visit, $"{student.Surname} {student.Name}", key);
                    key++;
                }

                DGVisits.ItemsSource = _dT.DefaultView;
            }
        }

        private void PreparingDGVisitsRows(List<GetVisitsByStudentJA> ttt, string fullName, int key)
        {
            DataRow name = _dT.NewRow();
            name[0] = fullName;
            for (var i = 1; i <= ttt.Count; i++)
            {
                if (ttt[i - 1].VisitStatus != true)
                {
                    name[i] = false;
                }
                else
                {
                    name[i] = ttt[i - 1].VisitStatus;
                }
                _dictionary.Add($"{key}x{i}", ttt[i - 1].Id);
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
            return _operation.GetAllStudentsByGroup(new GetAllStudentsByGroupQ(id));
        }


        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

        private void DGVisits_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            var id = _dictionary[$"{dg.SelectedIndex}x{dg.CurrentCell.Column.DisplayIndex}"];
        }
    }
}