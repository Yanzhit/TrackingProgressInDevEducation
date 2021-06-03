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
        /// Создание нового Лектора Группы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LectorGroup> SetNewLectorGroup(int lectorId, int groupId)
        {
            return (IEnumerable<LectorGroup>)Manager.Setter.Single(Query.SetNewLectorGroup(lectorId, groupId));
        }

        /// <summary>
        /// Обнуление таблицы Лекторы Группы
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LectorGroup> NullifyLectorGroup()
        {
            return (IEnumerable<LectorGroup>)Manager.Remove.Rem(Query.NullifyLectorGroup());
        }
    }
}