using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QTeam : IQuery
    {
        public Type Type { get; } = typeof(Team);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QTeam AddNewTeam(string name)
        {
            TypeQueries = TypeQueries.Set;
            Name = nameof(AddNewTeam);
            Params = $"{name}";
            return this;
        }
        public QTeam GetTeams()
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetTeams);
            Params = string.Empty;
            return this;
        }
        public QTeam GetTeamById(int id)
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetTeamById);
            Params = $"{id}";
            return this;
        }
        public QTeam UpdateTeamById(int id, string name)
        {
            TypeQueries = TypeQueries.Update;
            Name = nameof(UpdateTeamById);
            Params = $"{id}, {name}";
            return this;
        }
        public QTeam RemoveTeamById(int id)
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(RemoveTeamById);
            Params = $"{id}";
            return this;
        }
        public QTeam GetAllTeamsByLector(int lectorId)
        {
            TypeQueries = TypeQueries.Get;
            Name = GetType().Name;
            Params = $"{lectorId}";
            return this;
        }
        public QTeam NullifyTeams()
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(NullifyTeams);
            Params = string.Empty;
            return this;
        }
    }
}