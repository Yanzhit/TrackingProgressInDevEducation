using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Nullify;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class NullifyDB
    {
        public void Nullify(Type type) 
        {
            switch (type.Name)
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
            QuerySettings.QuerySet(new NullifyComments());
        }
        private void NullifyTableCommentType()
        {
            QuerySettings.QuerySet(new NullifyCommentType());
        }
        private void NullifyTableCourses()
        {
            QuerySettings.QuerySet(new NullifyCourses());
        }
        private void NullifyTableGroups()
        {
            QuerySettings.QuerySet(new NullifyGroups());
        }
        private void NullifyTableHomeworkComplete()
        {
            QuerySettings.QuerySet(new NullifyHomeworkComplete());
        }
        private void NullifyTableHomeworkGroup()
        {
            QuerySettings.QuerySet(new NullifyHomeworkGroup());
        }
        private void NullifyTableHomeworks()
        {
            QuerySettings.QuerySet(new NullifyHomeworks());
        }
        private void NullifyTableLections()
        {
            QuerySettings.QuerySet(new NullifyLections());
        }
        private void NullifyTableLectorGroup()
        {
            QuerySettings.QuerySet(new NullifyLectorGroup());
        }
        private void NullifyTableLectors()
        {
            QuerySettings.QuerySet( new NullifyLectors());
        }
        private void NullifyTablePayments()
        {
            QuerySettings.QuerySet(new NullifyPayments());
        }
        private void NullifyTableStudents()
        {
            QuerySettings.QuerySet(new NullifyStudents());
        }
        private void NullifyTableTeams()
        {
            QuerySettings.QuerySet(new NullifyTeams());
        }
        private void NullifyTableTeamStudent()
        {
            QuerySettings.QuerySet( new NullifyTeamStudent());
        }
        private void NullifyTableVisits()
        {
            QuerySettings.QuerySet(new NullifyVisits());
        }
    }
}