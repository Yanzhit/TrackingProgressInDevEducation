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
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.NewStudent;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for NewStudent.xaml
    /// </summary>
    public partial class NewStudent : Page
    {
        private readonly OperationLogics _operation = new();
        private readonly SingleContents _contents = SingleContents.GetContent();
        public NewStudent()
        {
            InitializeComponent();
            GetCitiesInPage();
            GetGroups();
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

        private void BCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            var answer = _operation.SetNewStudent(new SetNewStudentQ()
            {
                Surname = TBSurname.Text,
                Name = TBName.Text,
                MiddleName = TBMiddleName.Text,
                Contract = TBContractNumber.Text,
                CityId = CBChangeCity.SelectedIndex,
                Phone = CBChangeCity.Text,
                Email = TBEmail.Text,
                Git = TBGit.Text,
                Birthday = DPBDate.Text,
                GroupId = CBChangeGroup.SelectedIndex
            });
        }

        private void GetCitiesInPage()
        {
            List<GetCityA> answer = _operation.GetCities(new EmptyQ());
            foreach (var city in answer)
            {
                CBChangeCity.Items.Add(city.Name);
            }
            CBChangeCity.SelectedIndex = 0;
        }

        private void GetGroups()
        {
            List<GetGroupsA> answer = _operation.GetGroups(new EmptyQ());
            {
                foreach (var group in answer)
                {
                    CBChangeGroup.Items.Add(group.Name);
                }
                CBChangeGroup.SelectedIndex = 0;
            }
        }
    }
}
