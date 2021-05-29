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
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationUI.Pages.TestsPages;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        private MainForm _mainForm;
        private bool _isDevMod = true;
        private List<AbstractModels> _models = new List<AbstractModels>();
        public MainMenu(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            PreInstall();
        }

        private void PreInstall()
        {
            if (!_isDevMod)
            {
                QueriesTestButton.Visibility = Visibility.Hidden;
            }
        }

        private void QueriesTestButton_Click(object sender, RoutedEventArgs e)
        {
            QueriesTests queriesTests = new QueriesTests(_mainForm);
            _mainForm.Content = queriesTests;
        }

        private void DevModCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (DevModeCheckBox.IsChecked == true)
            {
                _isDevMod = true;
                QueriesTestButton.Visibility = Visibility.Visible;
            }
            else
            {
                _isDevMod = false;
                QueriesTestButton.Visibility = Visibility.Hidden;
            }
        }
    }
}
