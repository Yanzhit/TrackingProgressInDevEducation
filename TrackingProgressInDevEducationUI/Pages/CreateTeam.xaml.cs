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
using TrackingProgressInDevEducationBLL.Models.Team;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for CreateTeam.xaml
    /// </summary>
    public partial class CreateTeam : Page
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
        public CreateTeam()
        {
            InitializeComponent();
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            _contents.TeamInfo(2);
        }

        private void BCreatGroup_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BCreatTeam_Click(object sender, RoutedEventArgs e)
        {
            _contents.NewTeam = _contents.OperationLogics.SetNewTeam(new SetTeamQ()
            {
                TeamId = null,
                Name = TBTeamName.Text,
                LectorId = _contents.Lector.Id,
                From = DPTStartDate.Text,
                To = DPTEndDate.Text
            });

            _contents.CloseAdditionalWindows();
        }
    }
}
