using System;
using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

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
            //FacadeComments
            var query = new QComment();
            //QuerySettings.(query.NullifyComments());
        }
        private void NullifyTableCommentType()
        {
            
            
            var query = new QCommentType();
            //QuerySettings.QuerySet(query.NullifyCTypes());
        }
        private void NullifyTableCourses()
        {
            //FacadeCourses.
            var query = new QCourse();
            //QuerySettings.QuerySet(query.NullifyCourses());
        }
        private void NullifyTableGroups()
        {
            //FacadeGroups.
            var query = new QGroup();
            //QuerySettings.QuerySet(query.NullifyGroups());
        }
        private void NullifyTableHomeworkComplete()
        {
            //FacadeHomeworkComplete.
            var query = new QHomeworkComplete();
           // QuerySettings.QuerySet(query.NullifyHWComplete());
        }
        private void NullifyTableHomeworkGroup()
        {
            //FacadeHomeworkGroup.
            var query = new QHomeworkGroup();
            //QuerySettings.QuerySet(query.NullifyTableHomeworkGroup());
        }
        private void NullifyTableHomeworks()
        {
            //FacadeHomeworks.
            var query = new QHomework();
            //QuerySettings.QuerySet(query.NullifyHWs());
        }
        private void NullifyTableLections()
        {
            //FacadeLections.
            var query = new QLection();
            //QuerySettings.QuerySet(query.NullifyLections());
        }
        private void NullifyTableLectorGroup()
        {
            //FacadeLectorGroup
            var query = new QLectorGroup();
            //QuerySettings.QuerySet(query.NullifyLectorGroup());
        }
        private void NullifyTableLectors()
        {
            //FacadeLectors.
            var query = new QLector();
            //QuerySettings.QuerySet(query.NullifyLectors());
        }
        private void NullifyTablePayments()
        {
            //FacadePayments.
            var query = new QPayment();
            //QuerySettings.QuerySet(query.NullifyPayments());
        }
        //private void NullifyTableStudents()
        //{
        //    Students.NullifyStudents();
        //}
        //private void NullifyTableTeams()
        //{
        //    Teams.NullifyTeams();
        //}
        private void NullifyTableTeamStudent()
        {
            //FacadeTeamStudent.
            var query = new QTeamStudent();
            //QuerySettings.QuerySet(query.NullifyTStudent());
        }
        private void NullifyTableVisits()
        {
            //FacadeVisits.
            var query = new QVisit();
            //QuerySettings.QuerySet(query.NullifyVisits());
        }
    }
}