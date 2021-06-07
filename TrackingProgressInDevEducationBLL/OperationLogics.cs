using TrackingProgressInDevEducationBLL.Models.Registration;
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
        /// <param name="qGetLector">Входящая модель данных для отправки в DAL</param>
        /// <returns>Конечная модель данных для отправки в UI</returns>
        public AGetLector GetLoginAndPassword(QGetLector qGetLector)
        {
            Lector model = (Lector)_bllManager.QSignIns.GetLoginAndPassword(qGetLector);
            Lector modelReturned = _dalManager.Lectors.GetLoginAndPassword(model);
            return _bllManager.ASignIns.GetLoginAndPassword(modelReturned);
        }

        public ANewLector SetNewLector(QNewLector qNewLector)
        {
            Lector model = (Lector)_bllManager.QRegistrations.SetNewLector(qNewLector);
            Lector modelReturned = _dalManager.Lectors.SetNewLector(model);
            return _bllManager.ARegistrations.SetNewLector(modelReturned);
        }
    }
}