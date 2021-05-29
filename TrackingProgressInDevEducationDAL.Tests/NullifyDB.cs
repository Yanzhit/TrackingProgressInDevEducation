using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class NullifyDB
    {
        public void Nullify(Type type) 
        {
            switch (type.Name)
            {
                case nameof(Comment):
                    NullifyTableComments();
                    break;
                case nameof(CommentType):
                    NullifyTableCommentType();
                    break;
                case nameof(Course):
                    NullifyTableCourses();
                    break;
                case nameof(Group):
                    NullifyTableGroups();
                    break;
                case nameof(HomeworkComplete):
                    NullifyTableHomeworkComplete();
                    break;
                case nameof(HomeworkGroup):
                    NullifyTableHomeworkGroup();
                    break;
                case nameof(Homework):
                    NullifyTableHomeworks();
                    break;
                case nameof(Lection):
                    NullifyTableLections();
                    break;
                case nameof(LectorGroup):
                    NullifyTableLectorGroup();
                    break;
                case nameof(Lector):
                    NullifyTableLectors();
                    break;
                case nameof(Payment):
                    NullifyTablePayments();
                    break;
                case nameof(Student):
                    NullifyTableStudents();
                    break;
                case nameof(Team):
                    NullifyTableTeams();
                    break;
                case nameof(TeamStudent):
                    NullifyTableTeamStudent();
                    break;
                case nameof(Visit):
                    NullifyTableVisits();
                    break;
            }
        }
        private void NullifyTableComments()
        {
            var query = new QComment();
            QuerySettings.QuerySet(query.NullifyComments());
        }
        private void NullifyTableCommentType()
        {
            var query = new QCommentType();
            QuerySettings.QuerySet(query.NullifyCommentType());
        }
        private void NullifyTableCourses()
        {
            var query = new QCours();
            QuerySettings.QuerySet(query.NullifyCourses());
        }
        private void NullifyTableGroups()
        {
            var query = new QGroup();
            QuerySettings.QuerySet(query.NullifyGroups());
        }
        private void NullifyTableHomeworkComplete()
        {
            var query = new QHomeworkComplete();
            QuerySettings.QuerySet(query.NullifyHomeworkComplete());
        }
        private void NullifyTableHomeworkGroup()
        {
            var query = new QHomeworkGroup();
            //QuerySettings.QuerySet(query.NullifyTableHomeworkGroup());
        }
        private void NullifyTableHomeworks()
        {
            var query = new QHomework();
            QuerySettings.QuerySet(query.NullifyHomeworks());
        }
        private void NullifyTableLections()
        {
            var query = new QLection();
            QuerySettings.QuerySet(query.NullifyLections());
        }
        private void NullifyTableLectorGroup()
        {
            var query = new QLectorGroup();
            QuerySettings.QuerySet(query.NullifyLectorGroup());
        }
        private void NullifyTableLectors()
        {
            var query = new QLector();
            QuerySettings.QuerySet(query.NullifyLectors());
        }
        private void NullifyTablePayments()
        {
            var query = new QPayment();
            QuerySettings.QuerySet(query.NullifyPayments());
        }
        private void NullifyTableStudents()
        {
            var query = new QStudent();
            QuerySettings.QuerySet(query.NullifyStudents());
        }
        private void NullifyTableTeams()
        {
            var query = new QTeam();
            QuerySettings.QuerySet(query.NullifyTeams());
        }
        private void NullifyTableTeamStudent()
        {
            var query = new QTeamStudent();
            QuerySettings.QuerySet(query.NullifyTeamStudent());
        }
        private void NullifyTableVisits()
        {
            var query = new QVisit();
            QuerySettings.QuerySet(query.NullifyVisits());
        }
    }
}