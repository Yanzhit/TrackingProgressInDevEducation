﻿using System.Collections.Generic;
 using TrackingProgressInDevEducationDAL.Abstracts;
 using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class LectorCourses : AFacade 
    {
        public QLectorCourse Query { get; init; }

        public LectorCourse SetNewLectorCourse(int lectorId, int courseId)
        {
            return (LectorCourse) Manager.Setter.Single(Query.SetNewLectorCourse(lectorId, courseId));
        }

        /// <summary>
        /// Обнуление таблицы Лекторы Курсы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LectorCourse> NullifyCourse()
        {
            return (IEnumerable<LectorCourse>)Manager.Nullify.Null(Query.NullifyCourse());
        }
    }
}