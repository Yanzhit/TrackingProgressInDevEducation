﻿using System.Collections.Generic;
 using TrackingProgressInDevEducationDAL.Abstracts;
 using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class LectorGroups : AFacade 
    {
        public QLectorGroup Query { get; init; }

        /// <summary>
        /// Обнуление таблицы Лекторы Группы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LectorGroup> NullifyLectorGroup()
        {
            return (IEnumerable<LectorGroup>)QuerySet.QuerySet(Query.NullifyLectorGroup());
        }
    }
}