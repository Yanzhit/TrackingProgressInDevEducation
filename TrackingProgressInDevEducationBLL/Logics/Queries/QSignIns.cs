using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    /// <summary>
    /// Все запросы к BD со странице SignIn
    /// </summary>
    public class QSignIns : AQuery
    {
        /// <summary>
        /// Получить лектора по логину и паролю
        /// </summary>
        /// <param name="qGetLector">Модель с данными для запроса</param>
        /// <returns>Абстрактную модель данных после ответа от сервера</returns>
        public AbstractModel GetLoginAndPassword(QGetLector qGetLector)
        {
            WriteTypes(new SignInLector());
            return GetModelBaseSingle(qGetLector);
        }
    }
}