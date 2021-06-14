using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface ITeams
    {
        Team SetNewTeams(Team team);
        IEnumerable<Team> GetTeamById(Team team);
        IEnumerable<Team> NullifyTeams();
    }
}