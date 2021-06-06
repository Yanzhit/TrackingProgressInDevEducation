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

        public Lector GetLoginAndPassword(Lector model)
        {
            return (Lector)Manager.Getter.Single(_query.GetLoginAndPassword(model));
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