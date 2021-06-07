using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Lectors : AFacade 
    {
        private readonly QLector _query  = new();

        /// <summary>
        /// Создать нового Учителя
        /// </summary>
        /// <param name="lector">Объект данных</param>
        /// <returns>Учитель</returns>
        public Lector SetNewLector(Lector lector)
        {
            return (Lector)Manager.Setter.Single(_query.SetNewLector(lector));
        }

        public Lector UpdateAcrivationLector(Lector lector)
        {
            return (Lector)Manager.Setter.Single(_query.UpdateAcrivationLector(lector));
        }

        /// <summary>
        /// Вернуть учителя по ID
        /// </summary>
        /// <param name="lector">Объект данных</param>
        /// <returns>Учитель</returns>
        public Lector GetLectorById(Lector lector)
        {
            return (Lector)Manager.Getter.Single(_query.GetLectorById(lector));
        }

        public Lector GetLectorByLoginAndPassword(Lector model)
        {
            return (Lector)Manager.Getter.Single(_query.GetLectorByLoginAndPassword(model));
        }


        public IEnumerable<Lector> GetAllLectors()
        {
            return (IEnumerable<Lector>)Manager.Getter.Several(_query.GetAllLectors());
        }
        public IEnumerable<Lector> UpdNewEmailAndPasswordLectors()
        {
            return (IEnumerable<Lector>)Manager.Update.Upd(_query.UpdNewEmailAndPasswordLectors());
        }

        /// <summary>
        /// Обнуление таблицы Учителей и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Lector> NullifyLectors()
        {
            return (IEnumerable<Lector>)Manager.Remove.Rem(_query.NullifyLectors());
        }
    }
}