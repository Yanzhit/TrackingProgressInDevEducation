using System;
using System.Windows;
using System.Windows.Controls;
using TrackingProgressInDevEducationBLL;
using TrackingProgressInDevEducationBLL.Models.Comment;


namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for StudentRate.xaml
    /// </summary>
    public partial class StudentRate : Page
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
        //private readonly OperationLogics _operation = new OperationLogics();
        public StudentRate()
        {
            InitializeComponent();
        }        

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

        private void BAddComentStudent_Click(object sender, RoutedEventArgs e)
        {
            OperationLogics operation = new OperationLogics();
            var setNewComment = operation.SetNewCommentToStudent(new SetCommentsQ(TBHardSkills.Text, 1,  10 , 3, Convert.ToInt32(TBHardSkillsRate.Text)));

            // !!!  необходимо получить из другой страницы studentId,  createdBy
            //      Запрос для TBSoftSkills
            //var setNewComment = operation.SetNewCommentToStudent(new SetCommentsQ(TBSoftSkills.Text, 2, 10, 3, Convert.ToInt32(TBSoftSkillsRate.Text)));
            //      Запрос для TTBCommon
            //var setNewComment = operation.SetNewCommentToStudent(new SetCommentsQ(TBCommon.Text, 3,  10 , 3, Convert.ToInt32(TBCommonRate.Text)));

            MessageBox.Show("Комментарий добавлен");

        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            _contents.StudentProfile();
        }
    }
}
