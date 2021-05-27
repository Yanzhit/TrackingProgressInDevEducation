using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class RemoveTeamById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public RemoveTeamById(int id)
        {
            Type = typeof(Teams);
            Name = "RemoveTeamById";
            Params = $"{id}";
        }
    }
}
