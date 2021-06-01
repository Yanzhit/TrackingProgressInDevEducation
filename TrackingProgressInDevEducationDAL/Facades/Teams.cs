using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Abstarcts;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Teams : AFacade
    {
        public QTeam Query { get; set; }
        private readonly QTeam _qTeam = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Добавить новую команду
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Team SetNewTeam(string name)
        {
            return (Team)_query.QuerySet(_qTeam.SetNewTeam(name));
        }

        /// <summary>
        /// Обнулить таблицу команд
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Team> NullifyTeams()
        {
            return (IEnumerable<Team>)_query.QuerySet(_qTeam.NullifyTeams());
        }
    }
}