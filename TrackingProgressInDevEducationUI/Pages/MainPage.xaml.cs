using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrackingProgressInDevEducationBLL;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.MainPage;
using static TrackingProgressInDevEducationUI.Defines;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private int _tmp;
        private readonly OperationLogics _operation = new();
        private readonly SingleContents _contents = SingleContents.GetContent();
        private readonly ObservableCollection<GetGroupsByLectorA> _groups = new();
        private readonly ObservableCollection<GetAllTeamsByLectorJA> _teams = new();
        public MainPage()
        {
            InitializeComponent();
            Welcome();
            WriteTable();
        }

        private void Welcome()
        {
            WelcomeBlock.Content = $"{Welcome2}{Sep}{_contents.Lector.FullName}";
        }
        private void WriteTable()
        {
            TableGroup();
            TableTeam();
            SetGroup();
            SetTeam();
        }
        private void TableGroup()
        {
            _groups.Clear();
            var groups = (List<GetGroupsByLectorA>)RenderGroup();
            foreach (var group in groups)
            {
                _groups.Add(group);
            }
        }

        private void SetGroup()
        {
            GetGroupsByLectorA.ItemsSource = _groups;
        }
        private void SetTeam()
        {
            GetTeamsByLectorA.ItemsSource = _teams;
        }

        private IEnumerable<GetGroupsByLectorA> RenderGroup()
        {
            var query = new GetGroupsByLectorQ(_contents.Lector.Id); 
            return _operation.GetGroupsByLector(query);
        }
        private void TableTeam()
        {
            _teams.Clear();
            var teams = (List<GetAllTeamsByLectorJA>)RenderTeam();
            foreach (var team in teams)
            {
                _teams.Add(team);
            }
        }
        private IEnumerable<GetAllTeamsByLectorJA> RenderTeam()
        {
            var query = new GetAllTeamsByLectorJQ(_contents.Lector.Id);
            return _operation.GetAllTeamsByLectorJ(query);
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Student(object sender, RoutedEventArgs e)
        {
            _contents.Students();
        }

        private void Button_Click_CreateGroups(object sender, RoutedEventArgs e)
        {
            _contents.WinNewGroup();
            TableGroup();
        }

        private void Button_Click_CreateTeam(object sender, RoutedEventArgs e)
        {
            _contents.WinNewTeam();
            TableTeam();
        }

        private void GetTeamsByLectorA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void WelcomeBlock_Click(object sender, RoutedEventArgs e)
        {
            _contents.MyProfile();
        }

        private void Table_Click(object sender, RoutedEventArgs e)
        {
            var id = (int)(sender as Button).Tag;
            _contents.GroupJournal(id);
        }

        private void TableGroup_Click(object sender, RoutedEventArgs e)
        {
            var id = (int)(sender as Button).Tag;
            _contents.GroupInfo(id);
        }
    }
}
