using TrackingProgressInDevEducationDAL.Requests.Tables;
using TrackingProgressInDevEducationDAL.Abstarcts;
﻿using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class LectorCourses : AFacade 
    {
        public QLectorCourse Query { get; set; }

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