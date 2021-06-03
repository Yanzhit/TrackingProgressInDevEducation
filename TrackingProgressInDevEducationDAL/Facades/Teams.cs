using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Teams : AFacade
    {
        public QTeam Query { get; init; }

        /// <summary>
        /// Добавить новую команду
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Team SetNewTeam(string name)
        {
            return (Team) Manager.Setter.Single(Query.SetNewTeam(name));
        }

        /// <summary>
        /// Обнулить таблицу команд
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Team> NullifyTeams()
        {
            return (IEnumerable<Team>)Manager.Remove.Rem(Query.NullifyTeams());
        }
    }
}