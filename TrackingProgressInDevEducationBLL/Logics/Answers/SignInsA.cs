using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    /// <summary>
    /// Все ответы на запросы от BD для страницы SignIns
    /// </summary>
    public class SignInsA : AAnswer
    {
        /// <summary>
        /// Ответ от BD на запрос получение лектора по логину и паролю
        /// </summary>
        /// <param name="model">Входящая модель от DAL для обработки</param>
        /// <returns>Модель ответа с вложенными данными</returns>
        public GetLectorA GetLectorByLoginAndPassword(Lector model)
        {
            WriteTypes(new SignIns().GetLectorByLoginAndPassword());
            return (GetLectorA)GetModelBaseSingle(model);
        }
    }
}