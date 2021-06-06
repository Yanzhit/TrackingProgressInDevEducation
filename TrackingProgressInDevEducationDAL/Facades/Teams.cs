using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Teams : AFacade
    {
        private readonly QTeam _query  = new();

        /// <summary>
        /// Добавить новую команду
        /// </summary>
        /// <param name="team">Объект данных</param>
        /// <returns></returns>
        public AResult SetNewTeam(Team team)
        {
            return (AResult) Manager.Setter.Single(_query.SetNewTeam(team));
        }

        public IEnumerable<Team> GetTeamById(Team team)
        {
            return (IEnumerable<Team>)Manager.Getter.Single(_query.GetTeamById(team));
        }

        /// <summary>
        /// Обнулить таблицу команд
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyTeams()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyTeams());
        }
    }
}