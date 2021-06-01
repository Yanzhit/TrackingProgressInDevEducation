using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Lections
    {
        private readonly QLection _qLection = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Создать новую Лекцию
        /// </summary>
        /// <param name="groupId">ID Группы</param>
        /// <param name="lectorId">ID Учителя</param>
        /// /// <param name="startedOn">Начало Лекции</param>
        /// <returns>Лекция</returns>
        public Lection SetNewLection(int groupId, int lectorId, DateTime startedOn)
        {
            return (Lection)_query.QuerySet(_qLection.SetNewLection(groupId, lectorId, startedOn));
        }

        ///// <summary>
        ///// КОСЯК В ИМЕНИ МЕТОДА
        ///// </summary>
        ///// <returns></returns>
        //public IEnumerable<Lection> GetAllLector()
        //{
        //    return (List<Lection>)_query.QuerySet(_qLection.GetAllLector());
        //}

        /// <summary>
        /// Обнуление таблицы Лекций и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Lection> NullifyLections()
        {
            return (IEnumerable<Lection>)_query.QuerySet(_qLection.NullifyLections());
        }
    }
}