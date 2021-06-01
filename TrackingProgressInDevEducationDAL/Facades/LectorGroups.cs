using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class LectorGroups
    {
        private readonly QLectorGroup _qLectorGroup = new();
        private readonly QuerySettings _query = new();


        /// <summary>
        /// Обнуление таблицы ДЗ ГРУППЫ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<QHomeworkGroup> NullifyLectorGroup()
        {
            return (IEnumerable<QHomeworkGroup>)_query.QuerySet(_qLectorGroup.NullifyLectorGroup());
        }
    }
}