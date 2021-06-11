using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    /// <summary>
    /// Все запросы к BD со странице SignIns
    /// </summary>
    public class SignInsQ : AQuery
    {
        /// <summary>
        /// Получить лектора по логину и паролю
        /// </summary>
        /// <param name="model">Модель с данными для запроса</param>
        /// <returns>Абстрактную модель данных после ответа от сервера</returns>
        public AbstractModel GetLectorByLoginAndPassword(GetLectorQ model)
        {
            WriteTypes(new SignIns().GetLectorByLoginAndPassword());
            return GetModelBaseSingle(model);
        }
    }
}