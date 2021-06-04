using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Lectors : AFacade 
    {
        private readonly QLector _query  = new();

        /// <summary>
        /// Создать нового Учителя
        /// </summary>
        /// <param name="fullName">Полное имя</param>
        /// <param name="email">Эл.почта</param>
        /// /// <param name="password">Пароль</param>
        /// <returns>Учитель</returns>
        public Lector SetNewLector(string fullName, string email, string password)
        {
            return (Lector)Manager.Setter.Single(_query.SetNewLector(fullName, email, password));
        }

        /// <summary>
        /// Вернуть учителя по ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Учитель</returns>
        public Lector GetLectorById(int id)
        {
            return (Lector)Manager.Getter.Single(_query.GetLectorById(id));
        }

        public IEnumerable<Lector> GetAllLectors()
        {
            return (IEnumerable<Lector>)Manager.Getter.Several(_query.GetAllLectors());
        }
        public IEnumerable<AResult> UpdNewEmailAndPasswordLectors()
        {
            return (IEnumerable<AResult>)Manager.Update.Upd(_query.UpdNewEmailAndPasswordLectors());
        }

        /// <summary>
        /// Обнуление таблицы Учителей и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyLectors()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyLectors());
        }
    }
}