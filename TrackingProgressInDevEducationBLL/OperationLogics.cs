using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationBLL.Models.SignIn;
﻿using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;

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
        /// <param name="qGetLector">Входящая модель данных для отправки в DAL</param>
        /// <returns>Конечная модель данных для отправки в UI</returns>
        public AGetLector GetLectorByLoginAndPassword(QGetLector qGetLector)
        {
            Lector model = (Lector)_bllManager.QSignIns.GetLectorByLoginAndPassword(qGetLector);
            Lector modelReturned = _dalManager.Lectors.GetLectorByLoginAndPassword(model);
            return _bllManager.ASignIns.GetLectorByLoginAndPassword(modelReturned);
        }

        public ANewGroup SetNewGroup(QSetGroup qSetGroup)
        {
            Group model = (Group)_bllManager.QGroup.SetNewGroup(qSetGroup);
            Group modelReturned = _dalManager.Groups.SetNewGroup(model);
            return _bllManager.AGroups.SetNewGroup(modelReturned);
        }

        public ASetLector SetNewLector(QSetLector qSetLector)
        {
            Lector model = (Lector)_bllManager.QRegistrations.SetNewLector(qSetLector);
            Lector modelReturned = _dalManager.Lectors.SetNewLector(model);
            return _bllManager.ARegistrations.SetNewLector(modelReturned);
        }
    }
}