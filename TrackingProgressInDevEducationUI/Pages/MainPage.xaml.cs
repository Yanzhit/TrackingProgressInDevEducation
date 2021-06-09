using System;
using System.Collections.Generic;
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
using TrackingProgressInDevEducationBLL.Models.MainPage;
using static TrackingProgressInDevEducationUI.Defines;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private readonly OperationLogics _operation = new();
        private readonly SingleContents _contents = SingleContents.GetContent();
        public MainPage()
        {
            InitializeComponent();
            Welcome();
            WriteTable();
        }

        private void Welcome()
        {
            WelcomeBlock.Text = $"{Welcome2}{Sep}{_contents.Lector.FullName}";
        }
        private void WriteTable()
        {
            TableGroup();
            TableTeam();
        }
        private void TableGroup()
        {
            GetGroupsByLectorA.ItemsSource = RenderGroup();
            List<GetGroupsByLectorA> getGroups = (List<GetGroupsByLectorA>)RenderGroup();
        }

        private IEnumerable<GetGroupsByLectorA> RenderGroup()
        {
            GetGroupsByLectorQ query = new GetGroupsByLectorQ(_contents.Lector.Id); 
            return _operation.GetGroupsByLector(query);
        }
        private void TableTeam()
        {

        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WelcomeBlock_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_Student(object sender, RoutedEventArgs e)
        {
            _contents.Students();
        }

        private void Button_Click_CreateGroups(object sender, RoutedEventArgs e)
        {
            _contents.Group();
        }

        private void Button_Click_CreateTeam(object sender, RoutedEventArgs e)
        {
            _contents.CreateTeam();
        }
    }
}
