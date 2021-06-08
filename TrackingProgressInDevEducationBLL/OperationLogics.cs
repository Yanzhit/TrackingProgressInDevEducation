using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationBLL.Models.SignIn;
﻿using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.Verification;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models.MainPage;

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
            var model = (Course)_bllManager.CoursesQ.GetAllCourses(setCoursesQ);
            IEnumerable<Course> modelReturned = _dalManager.Courses.GetAllCourses();
            return (List<SetCoursesA>)_bllManager.CoursesA.GetSetCourses(modelReturned);
        }

        public List<GetGroupsByLectorA> GetGroupsByLector(GetGroupsByLectorQ getGroupsByLectorQ)
        {
            var model = (Group)_bllManager.MainPagesQ.GetGroupsByLectorQ(getGroupsByLectorQ);
            IEnumerable<Group> modelReturned = _dalManager.Groups.GetGroupsByLector(model);
            return (List<GetGroupsByLectorA>)_bllManager.MainPagesA.GetGroupsByLectorA(modelReturned);
        }
    }
}