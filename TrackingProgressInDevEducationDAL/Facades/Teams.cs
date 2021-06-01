using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Teams
    {
        private static readonly QTeam Query = new();
        //public static Team SetNewTeam(string name)
        //{
        //    return (Team) QuerySettings.QuerySet(Query.SetNewTeam(name));
        //}
        //public static IEnumerable<Team> NullifyTeams()
        //{
        //    return (List<Team>) QuerySettings.QuerySet(Query.NullifyTeams());
        //}
        //public static IEnumerable<Team> UpdateTeamById(int id, string name)
        //{
        //    return (List<Team>) QuerySettings.QuerySet(Query.UpdateTeamById(id, name));
        //}
        //public static IEnumerable<Team> GetTeamById(int id)
        //{
        //    return (List<Team>) QuerySettings.QuerySet(Query.GetTeamById(id));
        //}
        //public static IEnumerable<Team> RemoveTeamById(int id)
        //{
        //    return (List<Team>) QuerySettings.QuerySet(Query.RemoveTeamById(id));
        //}
        //public static IEnumerable<Team> GetTeams()
        //{
        //    return (List<Team>) QuerySettings.QuerySet(Query.GetTeams());
        //}
    }
}