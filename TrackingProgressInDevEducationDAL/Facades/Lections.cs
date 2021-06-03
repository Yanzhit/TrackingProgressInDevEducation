﻿using System;
using System.Collections.Generic;
 using TrackingProgressInDevEducationDAL.Abstracts;
 using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Lections : AFacade 
    {
        public QLection Query { get; init; }

        /// <summary>
        /// Создать новую Лекцию
        /// </summary>
        /// <param name="groupId">ID Группы</param>
        /// <param name="lectorId">ID Учителя</param>
        /// /// <param name="startedOn">Начало Лекции</param>
        /// <returns>Лекция</returns>
        public Lection SetNewLection(int groupId, int lectorId, DateTime startedOn)
        {
            return (Lection)Manager.Setter.Single(Query.SetNewLection(groupId, lectorId, startedOn));
        }

        ///// <summary>
        ///// КОСЯК В ИМЕНИ МЕТОДА
        ///// </summary>
        ///// <returns></returns>
        //public IEnumerable<Lection> GetAllLector()
        //{
        //    return (List<Lection>)_query.Manager(_qLection.GetAllLector());
        //}

        /// <summary>
        /// Обнуление таблицы Лекций и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Lection> NullifyLections()
        {
            return (IEnumerable<Lection>)Manager.Remove.Rem(Query.NullifyLections());
        }
    }
}