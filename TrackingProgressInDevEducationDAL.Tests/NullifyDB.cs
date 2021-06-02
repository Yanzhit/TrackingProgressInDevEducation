using System;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class NullifyDB
    {
        private readonly ManagerQueries _manager = new();

        public void Nullify(Type type) 
        {
            switch (type.Name)
            {
                case nameof(Comment):
                    NullifyTableComments();
                    break;
                case nameof(CType):
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
                case nameof(TStudent):
                    NullifyTableTeamStudent();
                    break;
                case nameof(Visit):
                    NullifyTableVisits();
                    break;
            }
        }

        private void NullifyTableComments()
        {
            _manager.Comments.NullifyComments();
        }

        private void NullifyTableCommentType()
        {
            _manager.CTypes.NullifyCTypes();
        }

        private void NullifyTableCourses()
        {
            _manager.Courses.NullifyCourses();
        }

        private void NullifyTableGroups()
        {
            _manager.Groups.NullifyGroups();
        }

        private void NullifyTableHomeworkComplete()
        {
            _manager.HWCompletes.NullifyHWComplete();
        }

        private void NullifyTableHomeworkGroup()
        {
            _manager.HWGroups.NullifyHWGroup();
        }

        private void NullifyTableHomeworks()
        {
            _manager.Homeworks.NullifyHWs();
        }

        private void NullifyTableLections()
        {
            _manager.Lections.NullifyLections();
        }

        private void NullifyTableLectorGroup()
        {
            _manager.LectorGroups.NullifyLectorGroup();
        }

        private void NullifyTableLectors()
        {
            _manager.Lectors.NullifyLectors();
        }

        private void NullifyTablePayments()
        {
            _manager.Payments.NullifyPayments();
        }

        private void NullifyTableStudents()
        {
            _manager.Students.NullifyStudents();
        }

        private void NullifyTableTeams()
        {
            _manager.Teams.NullifyTeams();
        }

        private void NullifyTableTeamStudent()
        {
            _manager.TStudents.NullifyTStudent();
        }

        private void NullifyTableVisits()
        {
            _manager.Visits.NullifyVisits();
        }
    }
}