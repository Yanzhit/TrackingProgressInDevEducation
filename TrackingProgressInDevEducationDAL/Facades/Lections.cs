﻿using System;
using System.Collections.Generic;
 using TrackingProgressInDevEducationDAL.Models.Bases;
 using TrackingProgressInDevEducationDAL.Models.Results;
 using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Lections : AFacade 
    {
        private readonly QLection _query  = new();

        /// <summary>
        /// Создать новую Лекцию
        /// </summary>
        /// <param name="courseId">ID Группы</param>
        /// <param name="lectorId">ID Учителя</param>
        /// /// <param name="startedOn">Начало Лекции</param>
        /// <returns>Лекция</returns>
        public AResult SetNewLection(int courseId, int lectorId, DateTime startedOn)
        {
            return (AResult)Manager.Setter.Single(_query.SetNewLection(courseId, lectorId, startedOn));
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
        public IEnumerable<AResult> NullifyLections()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyLections());
        }
    }
}