using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class QGroup : AQuery
    {
        /// <summary>
        /// Создать новую группу
        /// </summary>
        /// <param name="qSetGroup">Модель с данными для запроса</param>
        /// <returns>Абстрактную модель данных после ответа от сервера</returns>
        public AbstractModel SetNewGroup(QSetGroup qSetGroup)
        {
            WriteTypes(new GroupPage().SetNewGroup());
            return GetModelBaseSingle(qSetGroup);
        }
    }
}
