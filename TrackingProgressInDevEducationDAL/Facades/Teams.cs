using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Teams
    {
        private readonly QTeam _qTeam = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Добавить новую команду
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Student SetNewTeam(string name)
        {
            return (Student)_query.QuerySet(_qTeam.SetNewTeam(name));
        }

        /// <summary>
        /// Обнулить таблицу команд
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> NullifyTeams()
        {
            return (IEnumerable<Student>)_query.QuerySet(_qTeam.NullifyTeams());
        }
    }
}