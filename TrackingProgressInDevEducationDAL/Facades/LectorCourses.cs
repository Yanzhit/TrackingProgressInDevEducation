﻿using System.Collections.Generic;
 using TrackingProgressInDevEducationDAL.Abstracts;
 using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class LectorCourses : AFacade 
    {
        public QLectorCourse Query { get; init; }

        /// <summary>
        /// Обнуление таблицы Лекторы Курсы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LectorCourse> NullifyCourse()
        {
            return (IEnumerable<LectorCourse>)QuerySet.QuerySet(Query.NullifyCourse());
        }
    }
}