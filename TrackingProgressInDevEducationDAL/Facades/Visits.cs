using TrackingProgressInDevEducationDAL.Requests.Tables;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Visits : AFacade
    {
        public QVisit Query { get; init; }

        /// <summary>
        /// Добавить новое посещение
        /// </summary>
        /// <param name="visitStatus"></param>
        /// <param name="studentId"></param>
        /// <param name="lectionId"></param>
        /// <returns>Посещение</returns>
        public Visit SetNewVisit(bool visitStatus, int studentId, int lectionId)
        {
            return (Visit)Manager.Setter.Single(Query.SetNewVisit(visitStatus, studentId, lectionId));
        }

        /// <summary>
        /// Обнулить таблицу Посещений
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Visit> NullifyVisits()
        {
            return (IEnumerable<Visit>)Manager.Remove.Rem(Query.NullifyVisits());
        }
    }
}