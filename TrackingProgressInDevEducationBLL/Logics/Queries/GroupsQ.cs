using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class GroupsQ : AQuery
    {
        /// <summary>
        /// Создать новую группу
        /// </summary>
        /// <param name="setGroupQ">Модель с данными для запроса</param>
        /// <returns>Абстрактную модель данных после ответа от сервера</returns>
        public AbstractModel SetNewGroup(SetGroupQ setGroupQ)
        {
            WriteTypes(new Groups().SetNewGroup());
            return GetModelBaseSingle(setGroupQ);
        }
    }
}
