using System;
using System.Windows;
using System.Windows.Controls;
using TrackingProgressInDevEducationBLL;
using TrackingProgressInDevEducationBLL.Models.Comment;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for TeamRate.xaml
    /// </summary>
    public partial class TeamRate : Page
    {
        private readonly SingleContents _contents = SingleContents.GetContent();
        public TeamRate()
        {
            InitializeComponent();
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            _contents.MainPage();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            _contents.TeamInfo(2);
        }

        private void BAddComentToTeam_Click(object sender, RoutedEventArgs e)
        {
            OperationLogics operation = new OperationLogics();
            //var setNewComment = operation.SetNewCommentToStudent(new SetCommentsToTeamQ()
            //    {
            //        CreatedBy = 1,
            //        Estimation = 1,
            //        TeamId = 1,
            //        Text = TBHardSkills.Text,
            //        TypeId = Convert.ToInt32(TBHardSkillsRate.Text)
            //    });
            // !!!  необходимо получить из другой страницы TypeId,  createdBy
            //      Запрос для TBSoftSkills
            //  var setNewComment = operation.SetCommentToTeam(new SetCommentsToTeamQ(TBSoftSkills.Text, 1, 3, 1, Convert.ToInt32(TBSoftSkillsRate.Text)));
            //      Запрос для TTBCommon
            //  var setNewComment = operation.SetCommentToTeam(new SetCommentsToTeamQ(TBCommon.Text, 1, 3, 1, Convert.ToInt32(TBCommonRate.Text)));

            MessageBox.Show("Комментарий добавлен");
        }
    }
}
