﻿﻿using System.Collections.Generic;
 using TrackingProgressInDevEducationDAL.Models.Bases;
 using TrackingProgressInDevEducationDAL.Models.Results;
 using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class LectorCourses : AFacade 
    {
        private readonly QLectorCourse _query  = new();

        public AResult SetNewLectorCourse(int lectorId, int courseId)
        {
            return (AResult) Manager.Setter.Single(_query.SetNewLectorCourse(lectorId, courseId));
        }

        /// <summary>
        /// Обнуление таблицы Лекторы Курсы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyCourse()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyCourse());
        }
    }
}