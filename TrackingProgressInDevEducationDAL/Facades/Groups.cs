using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Groups
    {
        private readonly QGroup _qGroup = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Создать новую Группу
        /// </summary>
        /// <param name="name">Имя Группы</param>
        /// <returns>Группа</returns>
        public Course SetNewGroup(string name, int id)
        {
            return (Course) _query.QuerySet(_qGroup.SetNewGroup(name, id));
        }

        /// <summary>
        /// Обнуление таблицы Группы и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Course> NullifyGroups()
        {
            return (IEnumerable<Course>)_query.QuerySet(_qGroup.NullifyGroups());
        }
    }
}