using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class GetTeamById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetTeamById(int id)
        {
            Type = typeof(Teams);
            Name = "GetTeamById";
            Params = $"{id}";
        }
    }
}
