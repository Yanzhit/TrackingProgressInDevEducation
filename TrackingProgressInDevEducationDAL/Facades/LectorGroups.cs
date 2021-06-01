using TrackingProgressInDevEducationDAL.Requests.Tables;
using TrackingProgressInDevEducationDAL.Abstarcts;
﻿using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class LectorGroups : AFacade 
    {
        public QLectorGroup Query { get; set; }


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