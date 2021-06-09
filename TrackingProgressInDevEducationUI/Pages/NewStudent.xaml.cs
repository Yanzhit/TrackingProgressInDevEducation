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
            GetAllCitiesInPage();
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.Home();
        }

        private void BCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            OperationLogics operation = new OperationLogics();
            var setNewStudent = operation.SetNewStudent(new SetNewStudentQ(TBName.Text, TBSurname.Text, TBMiddleName.Text, TBPhone.Text, TBBirthday.Text));
            MessageBox.Show("Студент" + setNewStudent.Name + TBName.Text + " Создан!");
        }

        private void GetAllCitiesInPage()
        {
            OperationLogics operation = new OperationLogics();
            List<SetCityA> getAllCities = operation.GetAllCities(new EmptyQ());
            foreach (var city in getAllCities)
            {
                CBChangeCity.Items.Add(city.Name);
            }
        }
    }
}
