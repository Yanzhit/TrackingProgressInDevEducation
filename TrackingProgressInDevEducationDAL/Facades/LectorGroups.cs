﻿using System.Collections.Generic;
 using TrackingProgressInDevEducationDAL.Models.Bases;
 using TrackingProgressInDevEducationDAL.Models.Results;
 using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class LectorGroups : AFacade 
    {
        private readonly QLectorGroup _query  = new();

        /// <summary>
        /// Создание нового Лектора Группы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> SetNewLectorGroup(LectorGroup lGroup)
        {
            return (IEnumerable<AResult>)Manager.Setter.Single(_query.SetNewLectorGroup(lGroup));
        }

        /// <summary>
        /// Обнуление таблицы Лекторы Группы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyLectorGroup()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyLectorGroup());
        }
    }
}