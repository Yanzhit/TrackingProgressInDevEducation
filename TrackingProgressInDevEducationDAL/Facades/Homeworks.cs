using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Homeworks : AFacade
    {
        public QHomework Query { get; init; }

        /// <summary>
        /// Создать новое ДЗ
        /// </summary>
        /// <param name="name">Имя ДЗ</param>
        /// <returns>ДЗ</returns>
        public Homework SetNewHW(string name)
        {
            return (Homework)Manager.Setter.Single(Query.SetNewHW(name));
        }

        /// <summary>
        /// Обнуление таблицы ДЗ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Homework> NullifyHWs()
        {
            return (IEnumerable<Homework>)Manager.Remove.Rem(Query.NullifyHWs());
        }
    }
}