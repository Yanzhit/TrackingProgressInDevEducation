using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationBLL.Models.SignIn;
﻿using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.Verification;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Models.MainPage;
using TrackingProgressInDevEducationDAL.Models.Others;

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
            var model = (GetGroupByLectorJ)_bllManager.MainPagesQ.GetGroupsByLectorQ(getGroupsByLectorQ);
            IEnumerable<GetGroupByLectorJ> modelReturned = _dalManager.Joins.GetGroupByLectorJ(model);
            return (List<GetGroupsByLectorA>)_bllManager.MainPagesA.GetGroupsByLectorA(modelReturned);
        }

        public List<GetAllTeamsByLectorJA> GetAllTeamsByLectorJ(GetAllTeamsByLectorJQ getTeamssByLectorQ)
        {
            var model = (GetAllTeamsByLectorJ)_bllManager.MainPagesQ.GetAllTeamsByLectorJ(getTeamssByLectorQ);
            IEnumerable<GetAllTeamsByLectorJ> modelReturned = _dalManager.Joins.GetAllTeamsByLectorJ(model);
            return (List<GetAllTeamsByLectorJA>)_bllManager.MainPagesA.GetAllTeamsByLectorJA(modelReturned);
        }

        public List<SetCityA> GetAllCities(EmptyQ emptyQ)
        {
            var model = (City)_bllManager.CityQ.GetAllCities(emptyQ);
            IEnumerable<City> modelReturned = _dalManager.Cities.GetAllCities();
            return (List<SetCityA>)_bllManager.CityA.GetAllCities(modelReturned);
        }
    }
}