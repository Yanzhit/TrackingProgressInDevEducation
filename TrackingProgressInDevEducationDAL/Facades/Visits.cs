using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Visits
    {
        private readonly QVisit _qVisit = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Добавить новое посещение
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Посещение</returns>
        public Visit SetNewVisit(bool visitStatus, int studentId, int lectionId)
        {
            return (Visit)_query.QuerySet(_qVisit.SetNewVisit(visitStatus, studentId, lectionId));
        }

        /// <summary>
        /// Обнулить таблицу Посещений
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Visit> NullifyVisits()
        {
            return (IEnumerable<Visit>)_query.QuerySet(_qVisit.NullifyVisits());
        }
    }
}