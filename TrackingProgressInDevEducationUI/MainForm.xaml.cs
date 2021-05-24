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
        public MainForm()
        {
            InitializeComponent();
            StartSignIn();
        }

        /// <summary>
        /// Вызов страницы авторизации с задержкой в 2 секунды
        /// </summary>
        private void StartSignIn()
        {
            //Запуск задержки
            Task.Delay(2000).ContinueWith(_ =>
            {
                //Переброс вторичного потока в основной поток.
                Application.Current.Dispatcher.Invoke(() =>
                {
                    SignIn signIn = new SignIn(this);
                    this.Content = signIn;
                });                
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
