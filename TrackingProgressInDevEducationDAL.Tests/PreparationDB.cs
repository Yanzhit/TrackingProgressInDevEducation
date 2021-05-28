using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Nullify;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class PreparationDB
    {
        public void GetSettings(Type type)
        {
            switch (type.FullName)
            {
                case nameof(Comments):
                    NullifyTableComments();
                    break;
                case nameof(CommentType):
                    NullifyTableCommentType();
                    break;
                case nameof(Courses):
                    NullifyTableCourses();
                    break;
                case nameof(Groups):
                    NullifyTableGroups();
                    break;
                case nameof(HomeworkComplete):
                    NullifyTableHomeworkComplete();
                    break;
                case nameof(HomeworkGroup):
                    NullifyTableHomeworkGroup();
                    break;
                case nameof(Homeworks):
                    NullifyTableHomeworks();
                    break;
                case nameof(Lections):
                    NullifyTableLections();
                    break;
                case nameof(LectorGroup):
                    NullifyTableLectorGroup();
                    break;
                case nameof(Lectors):
                    NullifyTableLectors();
                    break;
                case nameof(Payments):
                    NullifyTablePayments();
                    break;
                case nameof(Students):
                    NullifyTableStudents();
                    break;
                case nameof(Teams):
                    NullifyTableTeams();
                    break;
                case nameof(TeamStudent):
                    NullifyTableTeamStudent();
                    break;
                case nameof(Visits):
                    NullifyTableVisits();
                    break;
            }
        }
        private void NullifyTableComments()
        {
            NullifyComments nullify = new NullifyComments();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableCommentType()
        {
            NullifyCommentType nullify = new NullifyCommentType();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableCourses()
        {
            NullifyCourses nullify = new NullifyCourses();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableGroups()
        {
            NullifyGroups nullify = new NullifyGroups();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableHomeworkComplete()
        {
            NullifyHomeworkComplete nullify = new NullifyHomeworkComplete();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableHomeworkGroup()
        {
            NullifyHomeworkGroup nullify = new NullifyHomeworkGroup();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableHomeworks()
        {
            NullifyHomeworks nullify = new NullifyHomeworks();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableLections()
        {
            NullifyLections nullify = new NullifyLections();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableLectorGroup()
        {
            NullifyLectorGroup nullify = new NullifyLectorGroup();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableLectors()
        {
            NullifyLectors nullify = new NullifyLectors();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTablePayments()
        {
            NullifyPayments nullify = new NullifyPayments();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableStudents()
        {
            NullifyStudents nullify = new NullifyStudents();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableTeams()
        {
            NullifyTeams nullify = new NullifyTeams();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableTeamStudent()
        {
            NullifyTeamStudent nullify = new NullifyTeamStudent();
            QuerySettings.QuerySet(nullify);
        }
        private void NullifyTableVisits()
        {
            NullifyVisits nullify = new NullifyVisits();
            QuerySettings.QuerySet(nullify);
        }

    }

}