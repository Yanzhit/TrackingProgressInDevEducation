using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Others;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Teams : AFacade
    {
        private readonly QTeam _query  = new();

        public IEnumerable<Team> GetTeamById(Team team)
        {
            return (IEnumerable<Team>)Manager.Getter.Single(_query.GetTeamById(team));
        }

        /// <summary>
        /// Обнулить таблицу команд
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Team> NullifyTeams()
        {
            return (IEnumerable<Team>)Manager.Remove.Rem(_query.NullifyTeams());
        }
    }
}