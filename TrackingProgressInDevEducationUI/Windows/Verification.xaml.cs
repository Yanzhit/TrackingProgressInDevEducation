using System;
using System.Windows;
using TrackingProgressInDevEducationBLL;
using TrackingProgressInDevEducationBLL.Models.Verification;

namespace TrackingProgressInDevEducationUI.Windows
{
    /// <summary>
    /// Логика взаимодействия для Verification.xaml
    /// </summary>
    public partial class Verification : Window
    {
        private readonly OperationLogics _operation = new();
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
                var query = new UpdLectorQ(_id, true);
                UpdLectorA answer = _operation.UpdateAcrivationLector(query);
                if (answer.IsActivated)
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
