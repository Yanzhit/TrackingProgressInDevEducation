﻿using System.Collections.Generic;
 using TrackingProgressInDevEducationDAL.Models.Bases;
 using TrackingProgressInDevEducationDAL.Models.Results;
 using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class LectorCourses : AFacade 
    {
        private readonly QLectorCourse _query  = new();

        public LectorCourse SetNewLectorCourse(LectorCourse lCourse)
        {
            return (LectorCourse) Manager.Setter.Single(_query.SetNewLectorCourse(lCourse));
        }

        /// <summary>
        /// Обнуление таблицы Лекторы Курсы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LectorCourse> NullifyCourse()
        {
            return (IEnumerable<LectorCourse>)Manager.Remove.Rem(_query.NullifyCourse());
        }
    }
}