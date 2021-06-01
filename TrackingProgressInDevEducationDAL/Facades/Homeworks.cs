using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Homeworks
    {
        private readonly QHomework _qHomework = new();
        private readonly QuerySettings _query = new();

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