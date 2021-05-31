using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;
using static TrackingProgressInDevEducationDAL.Defines;

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
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(AddNewTeam);
            Params = $"{name}";
            return this;
        }
        public QTeam GetTeams()
        {
            TypeQueries = TypeQueries.GetSeveral;
            Name = nameof(GetTeams);
            Params = string.Empty;
            return this;
        }
        public QTeam GetTeamById(int id)
        {
            TypeQueries = TypeQueries.GetOne;
            Name = nameof(GetTeamById);
            Params = $"{id}";
            return this;
        }
        public QTeam UpdateTeamById(int id, string name)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(UpdateTeamById);
            Params = $"{id}{Sep}{name}";
            return this;
        }
        public QTeam RemoveTeamById(int id)
        {
            TypeQueries = TypeQueries.RemoveOne;
            Name = nameof(RemoveTeamById);
            Params = $"{id}";
            return this;
        }
        public QTeam GetAllTeamsByLector(int lectorId)
        {
            TypeQueries = TypeQueries.GetSeveral;
            Name = GetType().Name;
            Params = $"{lectorId}";
            return this;
        }
        public QTeam NullifyTeams()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyTeams);
            Params = string.Empty;
            return this;
        }
    }
}