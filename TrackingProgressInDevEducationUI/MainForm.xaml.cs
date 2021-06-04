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
using System.Windows.Shapes;
using TrackingProgressInDevEducationUI.Pages;

namespace TrackingProgressInDevEducationUI
{
    /// <summary>
    /// Логика взаимодействия для MainForm.xaml
    /// </summary>
    public partial class MainForm : Window
    {
        private readonly SingleContents _contents;
        public MainForm()
        {
            InitializeComponent();
            _contents = SingleContents.SetForm(this);
            _ = StartSignIn();
        }

        /// <summary>
        /// Вызов страницы авторизации с задержкой в 2 секунды
        /// </summary>
        private async Task StartSignIn()
        {
            //Запуск задержки
            await Task.Delay(TimeSpan.FromSeconds(2));
            _contents.SignIn();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
