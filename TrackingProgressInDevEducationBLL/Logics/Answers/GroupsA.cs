using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    /// <summary>
    /// Все ответы на запросы от BD для страницы Group
    /// </summary>
    public class GroupsA : AAnswer
    {
        /// <summary>
        /// Ответ от BD на запрос создания новой группы
        /// </summary>
        /// <param name="model">Входящая модель от DAL для обработки</param>
        /// <returns>Модель ответа с вложенными данными</returns>
        public SetGroupA SetNewGroup(AbstractModel model)
        {
            WriteTypes(new Groups().SetNewGroup());
            return (SetGroupA)GetModelBaseSingle(model);
        }
    }
}