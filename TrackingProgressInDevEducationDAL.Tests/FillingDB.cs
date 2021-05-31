using System;
using TrackingProgressInDevEducationBLL.Facades.ForTables;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;
using TrackingProgressInDevEducationDAL.Tests.ModelsMock;
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
                case nameof(HomeworkComplete):
                    FillingTableHomeworkComplete();
                    break;
                case nameof(HomeworkGroup):
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
            foreach (MockComment data in _mock.Comments)
            {
                FacadeComments.SetNewComment(data.Text, data.TypeId, data.StudentId, data.CreatedBy, data.TeamId);
            }
        }
        private void FillingTableCommentType()
        {
            var query = new QCommentType();
            foreach (MockCommentType data in _mock.CommentType)
            {
                //FacadeCommentType.
                QuerySettings.QuerySet(query.SetNewCType(data.Name));
            }
        }
        private void FillingTableCourses()
        {
            var query = new QCourse();
            foreach (MockCourse data in _mock.Courses)
            {
                //FacadeCourses.
                QuerySettings.QuerySet(query.SetNewCourse(data.Name, data.StartedOn, data.FinishedOn));
            }
        }
        private void FillingTableGroups()
        {
            foreach (MockGroup data in _mock.Groups)
            {
                FacadeGroups.AddNewGroup(data.Name, data.CourseId);
            }
        }
        private void FillingTableHomeworkComplete()
        {
            //FacadeHomeworkComplete
            var query = new QHomeworkComplete();
            //QuerySettings.QuerySet(query.AddNewHomeworkComplete());
        }
        private void FillingTableHomeworkGroup()
        {
            //FacadeHomeworkGroup.
            var query = new QHomeworkGroup();
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
            foreach (MockLector data in _mock.Lectors)
            {
                FacadeLectors.AddNewLector(data.FullName);
            }
        }
        private void FillingTablePayments()
        {
            var query = new QPayment();
            foreach (MockPayment data in _mock.Payments)
            {
                //FacadePayments.
                QuerySettings.QuerySet(query.AddNewPayment(data.StudentId, data.PaymentTo, data.PaymentOn, data.Amount, data.Status));
            }
        }
        private void FillingTableStudents()
        {
            foreach (MockStudent data in _mock.Students)
            {
                FacadeStudent.AddNewStudent(data.Name, data.Surname, data.Rate);
            }
        }
        private void FillingTableTeams()
        {
            foreach (MockTeam data in _mock.Teams)
            {
                FacadeTeams.AddNewTeam(data.Name);
            }
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
            foreach (MockVisit data in _mock.Visits)
            {
                //FacadeVisits.
                QuerySettings.QuerySet(query.AddNewVisit(data.VisitStatus, data.StudentId, data.LectionId));
            }
        }
    }
}