using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
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
        public AResult SetNewGroup(Group group)
        {
            return (AResult)Manager.Setter.Single(_query.SetNewGroup(group));
        }

        public IEnumerable<Group> GetGroupsByLector(Group group)
        {
            return (IEnumerable<Group>)Manager.Getter.Several(_query.GetGroupsByLector(group));
        }

        /// <summary>
        /// Обнуление таблицы Группы и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyGroups()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyGroups());
        }
    }
}