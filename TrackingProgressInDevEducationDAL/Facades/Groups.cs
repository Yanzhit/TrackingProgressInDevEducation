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
        /// <param name="name">Имя Группы</param>
        /// <param name="courseId"></param>
        /// <returns>Группа</returns>
        public AResult SetNewGroup(string name, int courseId)
        {
            return (AResult)Manager.Setter.Single(_query.SetNewGroup(name, courseId));
        }

        public IEnumerable<Group> GetGroupsByLector(int lectorId)
        {
            return (IEnumerable<Group>)Manager.Getter.Several(_query.GetGroupsByLector(lectorId));
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