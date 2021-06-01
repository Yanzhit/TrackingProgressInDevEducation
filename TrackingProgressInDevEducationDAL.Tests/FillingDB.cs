using System;
using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;
using TrackingProgressInDevEducationDAL.Tests.WriteMockBase;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class FillingDB
    {
        private readonly MockBase _mock = PreparationDB.Mock;
        public void Filling(Type type) 
        {
            switch (type.Name)
            {
                case nameof(Comment):
                    new WriteComments().Write();
                    FillingTableComments();
                    break;
                case nameof(CommentType):
                    FillingTableCommentType();
                    break;
                case nameof(Course):
                    FillingTableCourses();
                    break;
                case nameof(Group):
                    FillingTableGroups();
                    break;
                case nameof(HWComplete):
                    FillingTableHomeworkComplete();
                    break;
                case nameof(HWGroup):
                    FillingTableHomeworkGroup();
                    break;
                case nameof(Homework):
                    FillingTableHomeworks();
                    break;
                case nameof(Lection):
                    FillingTableLections();
                    break;
                case nameof(LectorGroup):
                    FillingTableLectorGroup();
                    break;
                case nameof(Lector):
                    FillingTableLectors();
                    break;
                case nameof(Payment):
                    FillingTablePayments();
                    break;
                case nameof(Student):
                    FillingTableStudents();
                    break;
                case nameof(Team):
                    FillingTableTeams();
                    break;
                case nameof(TeamStudent):
                    FillingTableTeamStudent();
                    break;
                case nameof(Visit):
                    FillingTableVisits();
                    break;
            }
        }

        private void FillingTableComments()
        {
            //foreach (Comment data in _mock.Comments)
            //{
            //    Comments.SetNewComment(data.Text, data.TypeId, data.StudentId, data.CreatedBy, data.TeamId);
            //}
        }
        private void FillingTableCommentType()
        {
            //var query = new QCommentType();
            //foreach (CommentType data in _mock.CommentType)
            //{
            //    //FacadeCommentType.
            //    QuerySettings.QuerySet(query.SetNewCType(data.Name));
            //}
        }
        private void FillingTableCourses()
        {
            var query = new QCourse();
            //foreach (Course data in _mock.Courses)
            //{
            //    //FacadeCourses.
            //    QuerySettings.QuerySet(query.SetNewCourse(data.Name, data.StartedOn, data.FinishedOn));
            //}
        }
        private void FillingTableGroups()
        {
            foreach (Group data in _mock.Groups)
            {
                //Groups(data.Name, data.CourseId);
            }
        }
        private void FillingTableHomeworkComplete()
        {
            //FacadeHomeworkComplete
            var query = new QHWComplete();
            //QuerySettings.QuerySet(query.AddNewHomeworkComplete());
        }
        private void FillingTableHomeworkGroup()
        {
            //FacadeHomeworkGroup.
            var query = new QHWGroup();
            //QuerySettings.QuerySet(query.AddNewHomeworkGroup());
        }
        private void FillingTableHomeworks()
        {
            //foreach (MockHomework data in _mock.Homeworks)
            //{
            //    FacadeHomeworks.CreateNewHomeworks(data.Name);
            //}
        }
        private void FillingTableLections()
        {
            //FacadeLections.
            var query = new QLection();
            //QuerySettings.QuerySet(query.AddNewLections());
        }
        private void FillingTableLectorGroup()
        {
            //FacadeLectorGroup.
            var query = new QLectorGroup();
            //QuerySettings.QuerySet(query.AddNewLectorGroup());
        }
        private void FillingTableLectors()
        {
            //foreach (Lector data in _mock.Lectors)
            //{
            //    Lectors.SetNewLector(data.FullName, data.Email, data.Password);
            //}
        }
        private void FillingTablePayments()
        {
            var query = new QPayment();
            //foreach (Payment data in _mock.Payments)
            //{
            //    //FacadePayments.
            //    QuerySettings.QuerySet(query.AddNewPayment(data.StudentId, data.PaymentTo, data.PaymentOn, data.Amount, data.Status));
            //}
        }
        private void FillingTableStudents()
        {
            //foreach (Student data in _mock.Students)
            //{
            //    Students.SetNewStudent
            //        (
            //            data.Name,
            //            data.Surname,
            //            data.Rate,
            //            data.GroupId,
            //            data.Phone,
            //            data.Email,
            //            data.Contract,
            //            data.Birthday,
            //            data.MiddleName,
            //            data.Git,
            //            data.CityId,
            //            data.Status
            //        );
            //}
        }
        private void FillingTableTeams()
        {
            //foreach (Team data in _mock.Teams)
            //{
            //    Teams.SetNewTeam(data.Name);
            //}
        }
        private void FillingTableTeamStudent()
        {
            //FacadeTeamStudent.
            var query = new QTeamStudent();
            //QuerySettings.QuerySet(query.AddNewTeamStudent());
        }
        private void FillingTableVisits()
        {
            var query = new QVisit();
            //foreach (Visit data in _mock.Visits)
            //{
            //    //FacadeVisits
            //    QuerySettings.QuerySet(query.SetNewVisit(data.VisitStatus, data.StudentId, data.LectionId));
            //}
        }
    }
}