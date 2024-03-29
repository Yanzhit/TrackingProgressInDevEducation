﻿using TrackingProgressInDevEducationDAL.Requests.Tables;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Visits : AFacade
    {
        private readonly QVisit _query = new();

        /// <summary>
        /// Добавить новое посещение
        /// </summary>
        /// <param name="visitStatus"></param>
        /// <param name="studentId"></param>
        /// <param name="lectionId"></param>
        /// <returns>Посещение</returns>
        public AResult SetNewVisit(bool visitStatus, int studentId, int lectionId)
        {
            return (AResult)Manager.Setter.Single(_query.SetNewVisit(visitStatus, studentId, lectionId));
        }

        public IEnumerable<Visit> GetVisitsScore()
        {
            return (IEnumerable<Visit>)Manager.Getter.Several(_query.GetVisitsScore());
        }

        /// <summary>
        /// Обнулить таблицу Посещений
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyVisits()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyVisits());
        }
    }
}