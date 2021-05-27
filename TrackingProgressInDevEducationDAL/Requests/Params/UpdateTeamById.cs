using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class UpdateTeamById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateTeamById(int id, string name)
        {
            Type = typeof(Teams);
            Name = GetType().Name;
            Params = $"{id}, {name}";
        }
    }
}
