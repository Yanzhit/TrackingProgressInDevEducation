using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Lectors : AFacade 
    {
        public QLector Query { get; init; }

        /// <summary>
        /// Создать нового Учителя
        /// </summary>
        /// <param name="fullName">Полное имя</param>
        /// <param name="email">Эл.почта</param>
        /// /// <param name="password">Пароль</param>
        /// <returns>Учитель</returns>
        public Lector SetNewLector(string fullName, string email, string password)
        {
            return (Lector)Manager.Setter.Single(Query.SetNewLector(fullName, email, password));
        }

        /// <summary>
        /// Вернуть учителя по ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Учитель</returns>
        public Lector GetLectorById(int id)
        {
            return (Lector)Manager.Setter.Single(Query.GetLectorById(id));
        }

        /// <summary>
        /// Обнуление таблицы Учителей и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Lector> NullifyLectors()
        {
            return (IEnumerable<Lector>)Manager.Remove.Rem(Query.NullifyLectors());
        }
    }
}