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
using TrackingProgressInDevEducationBLL.Models.Group;
/*
SetNewGroups
GetAllCurses
*/
namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for Group.xaml
    /// </summary>
    public partial class Group : Page
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
        public Group()
        {
            InitializeComponent();
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.Home();
        }

        private void BCreatGroup_Click(object sender, RoutedEventArgs e)
        {
            OperationLogics operation = new OperationLogics();
            var sss = operation.SetNewGroup(new GroupQuery("name", 1, DateTime.MaxValue, DateTime.Now));

        }

        //private Course WriteAllCursesInComboBox ()
        //{

        //}
    }
}
