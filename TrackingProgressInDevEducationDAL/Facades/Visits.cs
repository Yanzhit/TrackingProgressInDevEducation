using TrackingProgressInDevEducationDAL.Requests.Tables;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Visits : AFacade, IVisits
    {
        private readonly QVisit _query = new();

        /// <summary>
        /// Добавить новое посещение
        /// </summary>
        /// <param name="visit">Объект данных</param>
        /// <returns>Посещение</returns>
        public Visit SetNewVisit(Visit visit)
        {
            return (Visit)Manager.Setter.Single(_query.SetNewVisit(visit));
        }

        public IEnumerable<Visit> GetVisitsScore()
        {
            return (IEnumerable<Visit>)Manager.Getter.Several(_query.GetVisitsScore());
        }

        /// <summary>
        /// Обнулить таблицу Посещений
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Visit> NullifyVisits()
        {
            return (IEnumerable<Visit>)Manager.Remove.Rem(_query.NullifyVisits());
        }
    }
}