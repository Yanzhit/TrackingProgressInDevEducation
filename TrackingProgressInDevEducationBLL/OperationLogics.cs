using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.Verification;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Models.MainPage;
using TrackingProgressInDevEducationDAL.Models.Others;
using TrackingProgressInDevEducationBLL.Models.GroupInfo;
using TrackingProgressInDevEducationBLL.Models.Comment;
using TrackingProgressInDevEducationBLL.Models.Students;

namespace TrackingProgressInDevEducationBLL
{
    /// <summary>
    /// Логический работник-обработчик запросов
    /// </summary>
    public class OperationLogics
    {
        /// <summary>
        /// Фасад DAL
        /// </summary>
        private readonly DALManager _dalManager = new();

        /// <summary>
        /// Фасад БЛЛ
        /// </summary>
        private readonly BLLManager _bllManager = new();

        /// <summary>
        /// Запрос на получение лектора, по логину и паролю
        /// </summary>
        /// <param name="getLectorQ">Входящая модель данных для отправки в DAL</param>
        /// <returns>Конечная модель данных для отправки в UI</returns>
        public GetLectorA GetLectorByLoginAndPassword(GetLectorQ getLectorQ)
        {
            var model = (Lector)_bllManager.SignInsQ.GetLectorByLoginAndPassword(getLectorQ);
            Lector modelReturned = _dalManager.Lectors.GetLectorByLoginAndPassword(model);
            return _bllManager.SignInsA.GetLectorByLoginAndPassword(modelReturned);
        }

        public SetGroupA SetNewGroup(SetGroupQ setGroupQ)
        {
            var model = (Group)_bllManager.GroupsQ.SetNewGroup(setGroupQ);
            Group modelReturned = _dalManager.Groups.SetNewGroup(model);
            return _bllManager.GroupsA.SetNewGroup(modelReturned);
        }
        //public GetGroupByIdJA GetGroupByIdJ(GetGroupByIdJQ getGroupByIdJQ)
        //{
        //    var model = (GetGroupByIdJ)_bllManager.GroupInfoQ.GetGroupByIdJ(getGroupByIdJQ);
        //    GetGroupByIdJ modelReturned = _dalManager.Joins.GetGroupByIdJ(model);
        //    return _bllManager.GroupInfoA.GetGroupByIdJA(modelReturned);
        //}
        
        public SetNewStudentA SetNewStudent(SetNewStudentQ setNewStudentQ)
        {
            var model = (Student)_bllManager.NewStudentQ.SetNewStudent(setNewStudentQ);
            Student modelReturned = _dalManager.Students.SetNewStudent(model);
            return _bllManager.NewStudentA.SetNewStudent(modelReturned);
        }

        public SetLectorA SetNewLector(SetLectorQ setLectorQ)
        {
            var model = (Lector)_bllManager.RegistrationsQ.SetNewLector(setLectorQ);
            Lector modelReturned = _dalManager.Lectors.SetNewLector(model);
            return _bllManager.RegistrationsA.SetNewLector(modelReturned);
        }
        public SetNewCoursesA SetNewCourse(SetNewCoursesQ setNewCoursesQ)
        {
            var model = (Course)_bllManager.NewCoureQ.SetNewCourse(setNewCoursesQ);
            Course modelReturned = _dalManager.Courses.SetNewCourse(model);
            return _bllManager.SenNewCourse.SetNewCourse(modelReturned);
        }
        
        public UpdLectorA UpdateAcrivationLector(UpdLectorQ updLectorQ)
        {
            var model = (Lector)_bllManager.VerificationsQ.UpdateActivationLector(updLectorQ);
            Lector modelReturned = _dalManager.Lectors.UpdateAcrivationLector(model);
            return _bllManager.VerificationsA.UpdateActivationLector(modelReturned);
        }

        public List<SetCoursesA> GetAllCurses(SetCoursesQ setCoursesQ)
        {
            _bllManager.CoursesQ.GetAllCourses(setCoursesQ);
            IEnumerable<Course> modelReturned = _dalManager.Courses.GetAllCourses();
            return (List<SetCoursesA>)_bllManager.CoursesA.GetSetCourses(modelReturned);
        }

        public List<GetGroupsByLectorA> GetGroupsByLector(GetGroupsByLectorQ getGroupsByLectorQ)
        {
            var model = (GetGroupByLectorJ)_bllManager.MainPagesQ.GetGroupsByLectorJ(getGroupsByLectorQ);
            IEnumerable<GetGroupByLectorJ> modelReturned = _dalManager.Joins.GetGroupByLectorJ(model);
            return (List<GetGroupsByLectorA>)_bllManager.MainPagesA.GetGroupsByLectorJ(modelReturned);
        }
        public List<GetAllStudentsByGroupA> GetAllStudentsByGroup(GetAllStudentsByGroupQ query)
        {
            var model = (GetAllStudentsByGroup)_bllManager.GroupInfosQ.GetAllStudentsByGroup(query);
            IEnumerable<GetAllStudentsByGroup> modelReturned = _dalManager.Joins.GetAllStudentsByGroup(model);
            return (List<GetAllStudentsByGroupA>)_bllManager.GroupInfosA.GetAllStudentsByGroupA(modelReturned);
        }
        //public List<GetAllCoursesByGroupA> GetAllCoursesByGroup(GetAllCoursesByGroupQ getAllCoursesByGroupQ)
        //{
        //    var model = (GetAllCoursesByGroup)_bllManager.GroupInfoQ.GetAllCoursesByGroup(getAllCoursesByGroupQ);
        //    IEnumerable<GetAllCoursesByGroup> modelReturned = _dalManager.Joins.GetAllCoursesByGroup(model);
        //    return (List<GetAllCoursesByGroupA>)_bllManager.GroupInfoA.GetAllCoursesByGroupA(modelReturned);
        //}

        public List<GetAllTeamsByLectorJA> GetAllTeamsByLectorJ(GetAllTeamsByLectorJQ getTeamssByLectorQ)
        {
            var model = (GetAllTeamsByLectorJ)_bllManager.MainPagesQ.GetAllTeamsByLectorJ(getTeamssByLectorQ);
            IEnumerable<GetAllTeamsByLectorJ> modelReturned = _dalManager.Joins.GetAllTeamsByLectorJ(model);
            return (List<GetAllTeamsByLectorJA>)_bllManager.MainPagesA.GetAllTeamsByLectorJ(modelReturned);
        }

        public List<GetCityA> GetCities(EmptyQ emptyQ)
        {
            var model = (City)_bllManager.CityQ.GetCities(emptyQ);
            IEnumerable<City> modelReturned = _dalManager.Cities.GetCities();
            return (List<GetCityA>)_bllManager.CityA.GetCities(modelReturned);
        }
        
        public List<GetGroupsA> GetGroups(EmptyQ emptyQ)
        {
            var model = (Group)_bllManager.CityQ.GetGroups(emptyQ);
            IEnumerable<Group> modelReturned = _dalManager.Groups.GetGroups();
            return (List<GetGroupsA>)_bllManager.CityA.GetGroups(modelReturned);
        }

        public SetCommentsA SetNewCommentToStudent(SetCommentsQ setCommentsQ)
        {
            var model = (Comment)_bllManager.CommentsQ.SetNewCommentToStudent(setCommentsQ);
            Comment modelReturned = _dalManager.Comments.SetNewCommentToStudent(model);
            return _bllManager.CommentsA.SetNewCommentToStudent(modelReturned);
        }

        public List<GetCommentsByStudentA> GetCommentsByStudent(GetCommentsByStudentQ getCommentsByStudentQ)
        {
            var model = (Comment)_bllManager.CommentsQ.GetCommentsByStudent(getCommentsByStudentQ);
            IEnumerable<Comment> modelReturned = _dalManager.Comments.GetCommentsByStudent(model);
            return (List<GetCommentsByStudentA>)_bllManager.CommentsA.GetCommentsByStudent(modelReturned);
        }

        public List<GetAllStudentsA> GetAllStudents(EmptyQ emptyQ)
        {
            var model = (Student)_bllManager.StudentsSQ.GetAllStudents(emptyQ);
            IEnumerable<Student> modelReturned = _dalManager.Students.GetAllStudents();
            return (List<GetAllStudentsA>)_bllManager.StudentsSA.GetAllStudents(modelReturned);
        }
    }
}