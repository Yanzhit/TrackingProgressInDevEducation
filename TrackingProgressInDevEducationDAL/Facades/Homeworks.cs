using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Homeworks : AFacade
    {
        private readonly QHomework _query  = new();

        /// <summary>
        /// Создать новое ДЗ
        /// </summary>
        /// <param name="homework">Объект данных</param>
        /// <returns>ДЗ</returns>
        public Homework SetNewHW(Homework homework)
        {
            return (Homework)Manager.Setter.Single(_query.SetNewHW(homework));
        }

        /// <summary>
        /// Обнуление таблицы ДЗ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Homework> NullifyHWs()
        {
            return (IEnumerable<Homework>)Manager.Remove.Rem(_query.NullifyHWs());
        }
    }
}