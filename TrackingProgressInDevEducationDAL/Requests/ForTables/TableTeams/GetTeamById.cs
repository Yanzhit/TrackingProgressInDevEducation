using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableTeams
{
    public class GetTeamById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetTeamById(int id)
        {
            Type = typeof(Teams);
            Name = GetType().Name;
            Params = $"{id}";
        }
    }
}
