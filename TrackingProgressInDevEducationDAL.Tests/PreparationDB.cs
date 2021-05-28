using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Interface;
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
                    break;
                case nameof(CommentType):
                    break;
                case nameof(Courses):
                    break;
                case nameof(Groups):
                    break;
                case nameof(HomeworkComplete):
                    break;
                case nameof(HomeworkGroup):
                    break;
                case nameof(Homeworks):
                    break;
                case nameof(Lections):
                    break;
                case nameof(LectorGroup):
                    break;
                case nameof(Lectors):
                    break;
                case nameof(Payments):
                    break;
                case nameof(Students):
                    break;
                case nameof(Teams):
                    break;
                case nameof(TeamStudent):
                    break;
                case nameof(Visits):
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