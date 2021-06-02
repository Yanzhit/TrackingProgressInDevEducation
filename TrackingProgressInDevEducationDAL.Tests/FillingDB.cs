using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.DataMock;

namespace TrackingProgressInDevEducationDAL.Tests
{
    
    public class FillingDB
    {
        private readonly ManagerQueries _manager = new();

        public void Filling(Type type, ManagerMocks manager)
        {
            switch (type.Name)
            {
                case nameof(City):
                    FillingCities(manager);
                    break;
                case nameof(Comment):
                    FillingTableComments(manager);
                    break;
                case nameof(CType):
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

        private void FillingCities(ManagerMocks manager)
        {
            DCities data = manager.DCities;

            for (var i = 0; i < data.Count; i++)
            {
                _manager.Cities.SetNewCity(data.Name[i]);
            }
        }

        private void FillingTableComments(ManagerMocks manager)
        {
            DComments data = manager.DComments;
            for (int i = 0; i < data.Count; i++)
            {
                _manager.Comments.SetNewComment
                (
                    data.Text[i],
                    data.TypeId[i],
                    data.StudentId[i],
                    data.CreatedBy[i],
                    data.TeamId[i]
                );
            }
        }

        private void FillingTableCommentType()
        {
            //foreach (CType data in _managerMock.CTypes)
            //{
            //    _manager.CommentTypes.SetNewCType(data.Name);
            //}
        }

        private void FillingTableCourses()
        {
            //foreach (Course data in _managerMock.Courses)
            //{
            //    _manager.Courses.SetNewCourse(data.Name, data.StartedOn, data.FinishedOn);
            //}
        }

        private void FillingTableGroups()
        {
            //foreach (Group data in _managerMock.Groups)
            //{
            //    _manager.Groups.SetNewGroup(data.Name, data.CourseId);
            //}
        }
        private void FillingTableHomeworkComplete()
        {
            //foreach (HWComplete data in _managerMock.HWCompletes)
            //{
            //    _manager.HWCompletes.SetNewHWComplete(data.HomeworkId, data.StudentId, data.Status);
            //}
        }

        private void FillingTableHomeworkGroup()
        {
            //FacadeHomeworkGroup.
            var query = new QHWGroup();
            //QuerySettings.QuerySet(query.AddNewHomeworkGroup());
        }

        private void FillingTableHomeworks()
        {
            //foreach (MockHomework data in _managerMock.Homeworks)
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
            //foreach (Lector data in _managerMock.Lectors)
            //{
            //    Lectors.SetNewLector(data.FullName, data.Email, data.Password);
            //}
        }

        private void FillingTablePayments()
        {
            var query = new QPayment();
            //foreach (Payment data in _managerMock.Payments)
            //{
            //    //FacadePayments.
            //    QuerySettings.QuerySet(query.AddNewPayment(data.StudentId, data.PaymentTo, data.PaymentOn, data.Amount, data.Status));
            //}
        }

        private void FillingTableStudents()
        {
            //foreach (Student data in _managerMock.Students)
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
            //foreach (Team data in _managerMock.Teams)
            //{
            //    Teams.SetNewTeam(data.Name);
            //}
        }
        private void FillingTableTeamStudent()
        {
            //FacadeTeamStudent.
            var query = new QTStudent();
            //QuerySettings.QuerySet(query.AddNewTeamStudent());
        }
        private void FillingTableVisits()
        {
            var query = new QVisit();
            //foreach (Visit data in _managerMock.Visits)
            //{
            //    //FacadeVisits
            //    QuerySettings.QuerySet(query.SetNewVisit(data.VisitStatus, data.StudentId, data.LectionId));
            //}
        }
    }
}