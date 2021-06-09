using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Others;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Groups : AFacade
    {
        private readonly QGroup _query  = new();

        /// <summary>
        /// Создать новую Группу
        /// </summary>
        /// <param name="group">Объект данных</param>
        /// <returns>Группа</returns>
        public Group SetNewGroup(Group group)
        {
            return (Group)Manager.Setter.Single(_query.SetNewGroup(group));
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