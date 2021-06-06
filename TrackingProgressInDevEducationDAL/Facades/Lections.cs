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
        /// <param name="lection">Объект данных</param>
        /// <returns>Лекция</returns>
        public Lection SetNewLection(Lection lection)
        {
            return (Lection)Manager.Setter.Single(_query.SetNewLection(lection));
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
            return (IEnumerable<Lection>)Manager.Remove.Rem(_query.NullifyLections());
        }
    }
}