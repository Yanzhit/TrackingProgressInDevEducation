﻿using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class LectorGroups : AFacade 
    {
        private readonly QLectorGroup _query  = new();

        /// <summary>
        /// Создание нового Лектора Группы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LectorGroup> SetNewLectorGroup(LectorGroup lGroup)
        {
            return (IEnumerable<LectorGroup>)Manager.Setter.Single(_query.SetNewLectorGroup(lGroup));
        }

        /// <summary>
        /// Обнуление таблицы Лекторы Группы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LectorGroup> NullifyLectorGroup()
        {
            return (IEnumerable<LectorGroup>)Manager.Remove.Rem(_query.NullifyLectorGroup());
        }
    }
}