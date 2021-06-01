using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class LectorGroups
    {
        private readonly QLectorGroup _qLectorGroup = new();
        private readonly QuerySettings _query = new();


        /// <summary>
        /// Обнуление таблицы Лекторы Группы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LectorGroup> NullifyLectorGroup()
        {
            return (IEnumerable<LectorGroup>)_query.QuerySet(_qLectorGroup.NullifyLectorGroup());
        }
    }
}