using System;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class NullifyDB
    {
        private readonly FacadeManager _facadeManager = new();

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
            _facadeManager.Comments.NullifyComments();
        }

        private void NullifyTableCommentType()
        {
            _facadeManager.CTypes.NullifyCTypes();
        }

        private void NullifyTableCourses()
        {
            _facadeManager.Courses.NullifyCourses();
        }

        private void NullifyTableGroups()
        {
            _facadeManager.Groups.NullifyGroups();
        }

        private void NullifyTableHomeworkComplete()
        {
            _facadeManager.HWCompletes.NullifyHWComplete();
        }

        private void NullifyTableHomeworkGroup()
        {
            _facadeManager.HWGroups.NullifyHWGroup();
        }

        private void NullifyTableHomeworks()
        {
            _facadeManager.Homeworks.NullifyHWs();
        }

        private void NullifyTableLections()
        {
            _facadeManager.Lections.NullifyLections();
        }

        private void NullifyTableLectorGroup()
        {
            _facadeManager.LectorGroups.NullifyLectorGroup();
        }

        private void NullifyTableLectors()
        {
            _facadeManager.Lectors.NullifyLectors();
        }

        private void NullifyTablePayments()
        {
            _facadeManager.Payments.NullifyPayments();
        }

        private void NullifyTableStudents()
        {
            _facadeManager.Students.NullifyStudents();
        }

        private void NullifyTableTeams()
        {
            _facadeManager.Teams.NullifyTeams();
        }

        private void NullifyTableTeamStudent()
        {
            _facadeManager.TStudents.NullifyTStudent();
        }

        private void NullifyTableVisits()
        {
            _facadeManager.Visits.NullifyVisits();
        }
    }
}