using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;
using TrackingProgressInDevEducationDAL.Abstarcts;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Homeworks : AFacade
    {
        public QHomework Query { get; set; }

        /// <summary>
        /// Создать новое ДЗ
        /// </summary>
        /// <param name="name">Имя ДЗ</param>
        /// <returns>ДЗ</returns>
        public Homework SetNewHW(string name)
        {
            return (Homework)_query.QuerySet(_qHomework.SetNewHW(name));
        }

        /// <summary>
        /// Обнуление таблицы ДЗ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Homework> NullifyHWs()
        {
            return (IEnumerable<Homework>)_query.QuerySet(_qHomework.NullifyHWs());
        }
    }
}