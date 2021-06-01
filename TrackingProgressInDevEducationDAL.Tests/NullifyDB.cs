using System;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class NullifyDB
    {
        private readonly FacadeQueries _facade = new();

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
                case nameof(HWComplete):
                    NullifyTableHomeworkComplete();
                    break;
                case nameof(HWGroup):
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
                  //  NullifyTableStudents();
                    break;
                case nameof(Team):
                 //   NullifyTableTeams();
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
            _facade.Comments.NullifyComments();
        }

        private void NullifyTableCommentType()
        {
            _facade.CommentTypes.NullifyCTypes();
        }

        private void NullifyTableCourses()
        {
            _facade.Courses.NullifyCourses();
        }

        private void NullifyTableGroups()
        {
            _facade.Groups.NullifyGroups();
        }

        private void NullifyTableHomeworkComplete()
        {
            _facade.HWCompletes.NullifyHWComplete();
        }

        private void NullifyTableHomeworkGroup()
        {
            _facade.HWGroups.NullifyHWGroup();
        }

        private void NullifyTableHomeworks()
        {
            _facade.Homeworks.NullifyHWs();
        }

        private void NullifyTableLections()
        {
            _facade.Lections.NullifyLections();
        }

        private void NullifyTableLectorGroup()
        {
            _facade.LectorGroups.NullifyLectorGroup();
        }

        private void NullifyTableLectors()
        {
            _facade.Lectors.NullifyLectors();
        }

        private void NullifyTablePayments()
        {
            _facade.Payments.NullifyPayments();
        }

        private void NullifyTableStudents()
        {
            _facade.Students.NullifyStudents();
        }

        private void NullifyTableTeams()
        {
            _facade.Teams.NullifyTeams();
        }

        private void NullifyTableTeamStudent()
        {
            _facade.TStudents.NullifyTStudent();
        }

        private void NullifyTableVisits()
        {
            _facade.Visits.NullifyVisits();
        }
    }
}