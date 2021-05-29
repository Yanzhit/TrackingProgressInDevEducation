using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;
using TrackingProgressInDevEducationDAL.Tests.ModelsMock;
using TrackingProgressInDevEducationDAL.Tests.WriteMockBase;
using Student = TrackingProgressInDevEducationDAL.Models.Bases.Student;

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
            var query = new QComment();
            foreach (MockComment data in _mock.Comments)
            {
                QuerySettings.QuerySet(query.AddNewComment(data.Text, data.TypeId, data.StudentId, data.CreatedBy));
            }
        }
        private void FillingTableCommentType()
        {
            var query = new QCommentType();
            foreach (MockCommentType data in _mock.CommentType)
            {
                QuerySettings.QuerySet(query.AddNewCommentType(data.Name));
            }
        }
        private void FillingTableCourses()
        {
            var query = new QCours();
            foreach (MockCourse data in _mock.Courses)
            {
                QuerySettings.QuerySet(query.AddNewCourse(data.Name, data.StartedOn, data.FinishedOn));
            }
        }
        private void FillingTableGroups()
        {
            var query = new QGroup();
            foreach (MockGroup data in _mock.Groups)
            {
                QuerySettings.QuerySet(query.AddNewGroup(data.Name, data.CourseId));
            }
        }
        private void FillingTableHomeworkComplete()
        {
            var query = new QHomeworkComplete();
            //QuerySettings.QuerySet(query.AddNewHomeworkComplete());
        }
        private void FillingTableHomeworkGroup()
        {
            var query = new QHomeworkGroup();
            //QuerySettings.QuerySet(query.AddNewHomeworkGroup());
        }
        private void FillingTableHomeworks()
        {
            var query = new QHomework();
            //QuerySettings.QuerySet(query.AddNewHomeworks());
        }
        private void FillingTableLections()
        {
            var query = new QLection();
            //QuerySettings.QuerySet(query.AddNewLections());
        }
        private void FillingTableLectorGroup()
        {
            var query = new QLectorGroup();
            //QuerySettings.QuerySet(query.AddNewLectorGroup());
        }
        private void FillingTableLectors()
        {
            var query = new QLector();
            foreach (MockLector data in _mock.Lectors)
            {
                QuerySettings.QuerySet(query.AddNewLector(data.FullName));
            }
        }
        private void FillingTablePayments()
        {
            var query = new QPayment();
            foreach (MockPayment data in _mock.Payments)
            {
                QuerySettings.QuerySet(query.AddNewPayment(data.StudentId, data.PaymentTo, data.PaymentOn, data.Amount, data.Status));
            }
        }
        private void FillingTableStudents()
        {
            var query = new QStudent();
            foreach (MockStudent data in _mock.Students)
            {
                QuerySettings.QuerySet(query.AddNewStudent(data.Name, data.Surname, data.Rate));
            }
        }
        private void FillingTableTeams()
        {
            var query = new QTeam();
            foreach (MockTeam data in _mock.Teams)
            {
                QuerySettings.QuerySet(query.AddNewTeam(data.Name));
            }
        }
        private void FillingTableTeamStudent()
        {
            var query = new QTeamStudent();
            //QuerySettings.QuerySet(query.AddNewTeamStudent());
        }
        private void FillingTableVisits()
        {
            var query = new QVisit();
            foreach (MockVisit data in _mock.Visits)
            {
                QuerySettings.QuerySet(query.AddNewVisit(data.VisitStatus, data.StudentId, data.LectionId));
            }
        }
    }
}