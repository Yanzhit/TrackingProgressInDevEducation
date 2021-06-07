using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.SignIn;
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
        /// <param name="lectorQuery">Входящая модель данных для отправки в DAL</param>
        /// <returns>Конечная модель данных для отправки в UI</returns>
        public LectorAnswer GetLoginAndPassword(LectorQuery lectorQuery)
        {
            Lector model = (Lector)_bllManager.QSignIns.GetLoginAndPassword(lectorQuery);
            Lector modelReturned = _dalManager.Lectors.GetLoginAndPassword(model);
            return _bllManager.ASignIns.GetLoginAndPassword(modelReturned);
        }
        public GroupAnswer SetNewGroup(GroupQuery groupQuery)
        {
            Group model = (Group)_bllManager.QGroup.SetNewGroup(groupQuery);
            Group modelReturned = _dalManager.Groups.SetNewGroup(model);
            return _bllManager.AGroups.SetNewGroup(modelReturned);
        }
    }
}