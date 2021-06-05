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
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationUI.Windows
{
    /// <summary>
    /// Логика взаимодействия для Verification.xaml
    /// </summary>
    public partial class Verification : Window
    {
        private readonly int _key;
        private readonly int _id;
        public Verification(int key, int id)
        {
            InitializeComponent();
            _id = id;
            _key = key;
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            if (_key == Convert.ToInt32(InputKey.Text))
            {
                Info.Text = Defines.Congratulation;
                FacadeManager f = new();
                Lector lector = f.Lectors.UpdateAcrivationLector(_id,true);
                if (lector.IsActivated == true)
                {
                    this.Close();
                    SingleContents.GetContent().SignIn();
                }
                else
                {
                    Info.Text = "Ошибка активации аккаунта";
                }
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
