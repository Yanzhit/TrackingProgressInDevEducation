using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Lectors
    {
        private readonly QLector _qLector = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Создать нового Учителя
        /// </summary>
        /// <param name="fullName">Полное имя</param>
        /// <param name="email">Эл.почта</param>
        /// /// <param name="password">Пароль</param>
        /// <returns>Учитель</returns>
        public Lector SetNewLector(string fullName, string email, string password)
        {
            return (Lector)_query.QuerySet(_qLector.SetNewLector(fullName, email, password));
        }

        /// <summary>
        /// Вернуть учителя по ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Учитель</returns>
        public Lector GetLectorById(int id)
        {
            return (Lector)_query.QuerySet(_qLector.GetLectorById(id));
        }

        /// <summary>
        /// Обнуление таблицы Учителей и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Lector> NullifyLectors()
        {
            return (IEnumerable<Lector>)_query.QuerySet(_qLector.NullifyLectors());
        }
    }
}