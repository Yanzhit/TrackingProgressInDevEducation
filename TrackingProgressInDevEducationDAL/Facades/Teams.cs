using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Teams : AFacade, ITeams
    {
        private readonly QTeam _query  = new();

        /// <summary>
        /// Добавить новую команду
        /// </summary>
        /// <param name="team">Объект данных</param>
        /// <returns></returns>
        public Team SetNewTeams(Team team)
        {
            return (Team) Manager.Setter.Single(_query.SetNewTeam(team));
        }

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