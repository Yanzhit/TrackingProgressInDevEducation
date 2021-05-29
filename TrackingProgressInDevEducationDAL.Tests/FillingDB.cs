using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables.TableComments;
using TrackingProgressInDevEducationDAL.Requests.ForTables.TableCommentType;
using TrackingProgressInDevEducationDAL.Requests.ForTables.TableCourses;
using TrackingProgressInDevEducationDAL.Requests.ForTables.TableGroups;
using TrackingProgressInDevEducationDAL.Requests.ForTables.TableLectors;
using TrackingProgressInDevEducationDAL.Requests.ForTables.TablePayments;
using TrackingProgressInDevEducationDAL.Requests.ForTables.TableStudents;
using TrackingProgressInDevEducationDAL.Requests.ForTables.TableTeams;
using TrackingProgressInDevEducationDAL.Requests.ForTables.TableVisits;
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
                case nameof(Comments):
                    new WriteComments().Write();
                    FillingTableComments();
                    break;
                case nameof(CommentType):
                    FillingTableCommentType();
                    break;
                case nameof(Courses):
                    FillingTableCourses();
                    break;
                case nameof(Groups):
                    FillingTableGroups();
                    break;
                case nameof(HomeworkComplete):
                    FillingTableHomeworkComplete();
                    break;
                case nameof(HomeworkGroup):
                    FillingTableHomeworkGroup();
                    break;
                case nameof(Homeworks):
                    FillingTableHomeworks();
                    break;
                case nameof(Lections):
                    FillingTableLections();
                    break;
                case nameof(LectorGroup):
                    FillingTableLectorGroup();
                    break;
                case nameof(Lectors):
                    FillingTableLectors();
                    break;
                case nameof(Payments):
                    FillingTablePayments();
                    break;
                case nameof(Students):
                    FillingTableStudents();
                    break;
                case nameof(Teams):
                    FillingTableTeams();
                    break;
                case nameof(TeamStudent):
                    FillingTableTeamStudent();
                    break;
                case nameof(Visits):
                    FillingTableVisits();
                    break;
            }
        }

        private void FillingTableComments()
        {
            foreach (MockComments data in _mock.Comments)
            {
                QuerySettings.QuerySet(new AddNewComment(data.Text, data.TypeId, data.StudentId, data.CreatedBy));
            }
        }
        private void FillingTableCommentType()
        {
            foreach (MockCommentType data in _mock.CommentType)
            {
                QuerySettings.QuerySet(new AddNewCommentType(data.Name));
            }
        }
        private void FillingTableCourses()
        {
            foreach (MockCourses data in _mock.Courses)
            {
                QuerySettings.QuerySet(new AddNewCourse(data.Name, data.StartedOn, data.FinishedOn));
            }
        }
        private void FillingTableGroups()
        {
            foreach (MockGroups data in _mock.Groups)
            {
                QuerySettings.QuerySet(new AddNewGroup(data.Name, data.CourseId));
            }
        }
        private void FillingTableHomeworkComplete()
        {
            //QuerySettings.QuerySet(new AddNewHomeworkComplete());
        }
        private void FillingTableHomeworkGroup()
        {
            //QuerySettings.QuerySet(new AddNewHomeworkGroup());
        }
        private void FillingTableHomeworks()
        {
            //QuerySettings.QuerySet(new AddNewHomeworks());
        }
        private void FillingTableLections()
        {
            //QuerySettings.QuerySet(new AddNewLections());
        }
        private void FillingTableLectorGroup()
        {
            //QuerySettings.QuerySet(new AddNewLectorGroup());
        }
        private void FillingTableLectors()
        {
            foreach (MockLectors data in _mock.Lectors)
            {
                QuerySettings.QuerySet(new AddNewLector(data.FullName));
            }
        }
        private void FillingTablePayments()
        {
            foreach (MockPayments data in _mock.Payments)
            {
                QuerySettings.QuerySet(new AddNewPayment(data.StudentId, data.PaymentTo, data.PaymentOn, data.Amount, data.Status));
            }
        }
        private void FillingTableStudents()
        {
            foreach (MockStudents data in _mock.Students)
            {
                QuerySettings.QuerySet(new AddNewStudent(data.Name, data.Surname, data.Rate));
            }
        }
        private void FillingTableTeams()
        {
            foreach (MockTeams data in _mock.Teams)
            {
                QuerySettings.QuerySet(new AddNewTeam(data.Name));
            }
        }
        private void FillingTableTeamStudent()
        {
            //QuerySettings.QuerySet( new AddNewTeamStudent());
        }
        private void FillingTableVisits()
        {
            foreach (MockVisits data in _mock.Visits)
            {
                QuerySettings.QuerySet(new AddNewVisit(data.VisitStatus, data.StudentId, data.LectionId));
            }
        }
    }
}