using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Others;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Groups : AFacade, IGroups
    {
        private readonly QGroup _query  = new();


        /// <summary>
        /// Обнуление таблицы Группы и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Group> GetGroups()
        {
            return (IEnumerable<Group>)Manager.Getter.Several(_query.GetGroups());
        }
        
        /// <summary>
        /// Обнуление таблицы Группы и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Group> NullifyGroups()
        {
            return (IEnumerable<Group>)Manager.Remove.Rem(_query.NullifyGroups());
        }
    }
}