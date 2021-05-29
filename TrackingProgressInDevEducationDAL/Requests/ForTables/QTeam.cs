using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QTeam : IQuery
    {
        public Type Type { get; } = typeof(Team);
        public string Name { get; set; }
        public string Params { get; set; }

        public QTeam AddNewTeam(string name)
        {
            Name = nameof(AddNewTeam);
            Params = $"{name}";
            return this;
        }
        public QTeam GetTeams()
        {
            Name = nameof(GetTeams);
            Params = string.Empty;
            return this;
        }
        public QTeam GetTeamById(int id)
        {
            Name = nameof(GetTeamById);
            Params = $"{id}";
            return this;
        }
        public QTeam UpdateTeamById(int id, string name)
        {
            Name = nameof(UpdateTeamById);
            Params = $"{id}, {name}";
            return this;
        }
        public QTeam RemoveTeamById(int id)
        {
            Name = nameof(RemoveTeamById);
            Params = $"{id}";
            return this;
        }
        public QTeam NullifyTeams()
        {
            Name = nameof(NullifyTeams);
            Params = string.Empty;
            return this;
        }
    }
}