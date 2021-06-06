using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Queries
{
    /// <summary>
    /// Все запросы к BD со странице SignIn
    /// </summary>
    public class QSignIns : AQuery
    {
        /// <summary>
        /// Получить лектора по логину и паролю
        /// </summary>
        /// <param name="lectorQuery">Модель с данными для запроса</param>
        /// <returns>Абстрактную модель данных после ответа от сервера</returns>
        public AbstractModel GetLoginAndPassword(LectorQuery lectorQuery)
        {
            WriteTypes(new SignInLector());
            return GetModelBaseSingle(lectorQuery);
        }
    }
}