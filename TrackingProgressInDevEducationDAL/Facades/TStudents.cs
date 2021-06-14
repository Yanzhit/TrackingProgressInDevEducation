using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class TStudents : AFacade, ITStudents
    {
        private readonly QTStudent _query  = new();

        /// <summary>
        /// Добавить новую Команду к студентам
        /// </summary>
        /// <param name="tStudent">Объект данных</param>
        /// <returns></returns>
        public TStudent SetNewTStudent(TStudent tStudent)
        {
            return (TStudent)Manager.Setter.Single(_query.SetNewTStudent(tStudent));
        }
       
        /// <summary>
        /// Обнуление таблицы Команда Студенты
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TStudent> NullifyTStudent()
        {
            return (IEnumerable<TStudent>)Manager.Remove.Rem(_query.NullifyTStudent());
        }
    }
}