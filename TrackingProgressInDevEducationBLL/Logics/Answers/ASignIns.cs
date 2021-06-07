using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    /// <summary>
    /// Все ответы на запросы от BD для страницы SignIn
    /// </summary>
    public class ASignIns : AAnswer
    {
        /// <summary>
        /// Ответ от BD на запрос получение лектора по логину и паролю
        /// </summary>
        /// <param name="model">Входящая модель от DAL для обработки</param>
        /// <returns>Модель ответа с вложенными данными</returns>
        public AGetLector GetLectorByLoginAndPassword(Lector model)
        {
            WriteTypes(new SignIn().GetLectorByLoginAndPassword());
            return (AGetLector)GetModelBaseSingle(model);
        }
    }
}