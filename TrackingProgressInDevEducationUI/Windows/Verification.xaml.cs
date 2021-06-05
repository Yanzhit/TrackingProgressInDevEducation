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

namespace TrackingProgressInDevEducationUI.Windows
{
    /// <summary>
    /// Логика взаимодействия для Verification.xaml
    /// </summary>
    public partial class Verification : Window
    {
        private readonly int _key;
        public Verification(int key)
        {
            InitializeComponent();
            _key = key;
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            if (_key == Convert.ToInt32(InputKey.Text))
            {
                Info.Text = Defines.Congratulation;
                this.Close();
                SingleContents.GetContent().SignIn();
            }
            else
            {
                Info.Text = "Повторите ввод";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
