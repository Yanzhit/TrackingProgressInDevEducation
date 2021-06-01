using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class LectorCourses
    {
        private readonly QLectorCourse _qLectorCourse = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Обнуление таблицы Лекторы Курсы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LectorCourse> NullifyCourse()
        {
            return (IEnumerable<LectorCourse>)_query.QuerySet(_qLectorCourse.NullifyCourse());
        }
    }
}