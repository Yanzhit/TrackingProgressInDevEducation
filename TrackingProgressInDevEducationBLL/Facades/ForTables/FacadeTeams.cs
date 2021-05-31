using System.Collections.Generic;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationBLL.Facades.ForTables
{
    public class FacadeTeams
    {
        private static readonly QTeam Query = new();
        public static IEnumerable<Team> UpdateTeamById(int id, string name)
        {
            return (List<Team>) QuerySettings.QuerySet(Query.UpdateTeamById(id, name));
        }
        public static IEnumerable<Team> GetTeamById(int id)
        {
            return (List<Team>) QuerySettings.QuerySet(Query.GetTeamById(id));
        }
        public static IEnumerable<Team> RemoveTeamById(int id)
        {
            return (List<Team>) QuerySettings.QuerySet(Query.RemoveTeamById(id));
        }
        public static IEnumerable<Team> GetTeams()
        {
            return (List<Team>) QuerySettings.QuerySet(Query.GetTeams());
        }
        public static IEnumerable<Team> AddNewTeam(string name)
        {
            return (List<Team>) QuerySettings.QuerySet(Query.AddNewTeam(name));
        }
    }
}