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
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

        private void BCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            var answer = _operation.SetNewStudent(new SetNewStudentQ(groupId: 2, name: "asdqw", cityId:1, email:"qeqew"));
            MessageBox.Show("Студент" + TBName.Text + " Создан!");
        }

        private void GetCitiesInPage()
        {
            List<GetCityA> answer = _operation.GetCities(new EmptyQ());
            foreach (var city in answer)
            {
                CBChangeCity.Items.Add(city.Name);
            }
        }

        private void CBChangeGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<GetGroupsA> answer = _operation.GetGroups(new EmptyQ());
            {
                foreach (var group in answer)
                {
                    CBChangeGroup.Items.Add(group.Name);
                }
            }
        }
    }
}
