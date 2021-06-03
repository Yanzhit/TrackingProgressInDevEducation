using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Groups : AFacade
    {
        public QGroup Query { get; init; }

        /// <summary>
        /// Создать новую Группу
        /// </summary>
        /// <param name="name">Имя Группы</param>
        /// <param name="courseId"></param>
        /// <returns>Группа</returns>
        public Group SetNewGroup(string name, int courseId)
        {
            return (Group)Manager.Setter.Single(Query.SetNewGroup(name, courseId));
        }

        /// <summary>
        /// Обнуление таблицы Группы и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Group> NullifyGroups()
        {
            return (IEnumerable<Group>)Manager.Remove.Rem(Query.NullifyGroups());
        }
    }
}