using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests
{
    
    public class FillingDB
    {
        private readonly DALManager _manager = new();

        public void Filling(Type type, ManagerMocks manager)
        {
            switch (type.Name)
            {
                case nameof(City):
                    FillingCities(manager);
                    break;
                case nameof(Comment):
                    FillingComments(manager);
                    break;
                case nameof(CType):
                    FillingCType(manager);
                    break;
                case nameof(Course):
                    FillingCourses(manager);
                    break;
                case nameof(Group):
                    FillingGroups(manager);
                    break;
                case nameof(HWComplete):
                    FillingHWComplete(manager);
                    break;
                case nameof(HWGroup):
                    FillingHWGroup(manager);
                    break;
                case nameof(Homework):
                    FillingHomeworks(manager);
                    break;
                case nameof(Lection):
                    FillingLections(manager);
                    break;
                case nameof(LectorGroup):
                    FillingLectorGroup(manager);
                    break;
                case nameof(Lector):
                    FillingLectors(manager);
                    break;
                case nameof(Payment):
                    FillingPayments(manager);
                    break;
                case nameof(Student):
                    FillingStudents(manager);
                    break;
                case nameof(Team):
                    FillingTeams(manager);
                    break;
                case nameof(TStudent):
                    FillingTStudents(manager);
                    break;
                case nameof(Visit):
                    FillingVisits(manager);
                    break;
            }
        }

        private void FillingCities(ManagerMocks manager)
        {
            List<City> cities = manager.DCities.Cities;
            foreach (var city in cities)
            {
                _manager.Cities.SetNewCity(city.Name);
            }
        }

        private void FillingComments(ManagerMocks manager)
        {
            List<Comment> comments = manager.DComments.Comments;
            foreach (var comment in comments)
            {
                _manager.Comments.SetNewComment
                (
                    comment.Text,
                    comment.TypeId,
                    comment.StudentId,
                    comment.CreatedBy,
                    comment.TeamId
                );
            }
        }

        private void FillingCType(ManagerMocks manager)
        {
            List<CType> cTypes = manager.DCTypes.CTypes;
            foreach (var cType in cTypes)
            {
                _manager.CTypes.SetNewCType(cType.Name);
            }
        }

        private void FillingCourses(ManagerMocks manager)
        {
            List<Course> courses = manager.DCourses.Courses;
            foreach (var course in courses)
            {
                _manager.Courses.SetNewCourse(course.Name, course.StartedOn, course.FinishedOn);
            }
        }

        private void FillingGroups(ManagerMocks manager)
        {
            List<Group> groups = manager.DGroups.Groups;
            foreach (var group in groups)
            {
                _manager.Groups.SetNewGroup(group.Name, group.CourseId);
            }
        }
        private void FillingHWComplete(ManagerMocks manager)
        {
            List<HWComplete> hwCompletes = manager.DHWCompletes.HWCompletes;
            foreach (var hwComplete in hwCompletes)
            {
                _manager.HWCompletes.SetNewHWComplete(hwComplete.HomeworkId, hwComplete.StudentId, hwComplete.Status);
            }
        }

        private void FillingHWGroup(ManagerMocks manager)
        {
            List<HWGroup> hwGroups = manager.DHWGroups.HWGroups;
            foreach (var hwGroup in hwGroups)
            {
                _manager.HWGroups.SetNewHWGroup(hwGroup.HomeworkId, hwGroup.GroupId);
            }
        }

        private void FillingHomeworks(ManagerMocks manager)
        {
            List<Homework> homeworks = manager.DHomeworks.Homeworks;
            foreach (var hwGroup in homeworks)
            {
                _manager.Homeworks.SetNewHW(hwGroup.Name);
            }
        }

        private void FillingLections(ManagerMocks manager)
        {
            List<Lection> lections = manager.DLections.Lections;
            foreach (var lection in lections)
            {
               // _manager.Lections.SetNewLection();
            }
        }

        private void FillingLectorGroup(ManagerMocks manager)
        {
            List<LectorGroup> lectorGroups = manager.DLectorGroups.LectorGroups;
            foreach (var lectorGroup in lectorGroups)
            {
                _manager.LectorGroups.SetNewLectorGroup(lectorGroup.LectorId, lectorGroup.GroupId);
            }
        }

        private void FillingLectors(ManagerMocks manager)
        {
            List<Lector> lectors = manager.DLectors.Lectors;
            foreach (var lector in lectors)
            {
                _manager.Lectors.SetNewLector(lector.FullName, lector.Email, lector.Password);
            }
        }

        private void FillingPayments(ManagerMocks manager)
        {
            List<Payment> payments = manager.DPayments.Payments;
            foreach (var payment in payments)
            {
                _manager.Payments.SetNewPayment
                (
                    payment.StudentId,
                    payment.PaymentTo,
                    payment.PaymentOn,
                    payment.Amount,
                    payment.Status
                );
            }
        }

        private void FillingStudents(ManagerMocks manager)
        {
            List<Student> students = manager.DStudents.Students;
            foreach (var student in students)
            {
                _manager.Students.SetNewStudent
                (
                    student.Name,
                    student.Surname,
                    student.Rate,
                    student.GroupId,
                    student.Phone,
                    student.Email,
                    student.Contract,
                    student.Birthday,
                    student.MiddleName,
                    student.Git,
                    student.CityId,
                    student.Status
                );
            }
        }
        private void FillingTeams(ManagerMocks manager)
        {
            List<Team> teams = manager.DTeams.Teams;
            foreach (var team in teams)
            {
                _manager.Teams.SetNewTeam(team.Name);
            }
        }

        private void FillingTStudents(ManagerMocks manager)
        {
            List<TStudent> tStudents = manager.DTStudents.TStudents;
            foreach (var tStudent in tStudents)
            {
                _manager.TStudents.SetNewTStudent(tStudent.TeamId, tStudent.StudentId);
            }
        }

        private void FillingVisits(ManagerMocks manager)
        {
            List<Visit> visits = manager.DVisits.Visits;
            foreach (var visit in visits)
            {
                _manager.Visits.SetNewVisit(visit.VisitStatus, visit.StudentId, visit.LectionId);
            }
        }
    }
}