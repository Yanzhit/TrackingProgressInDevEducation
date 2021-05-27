using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class GetTeams : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetTeams()
        {
            Type = typeof(Teams);
            Name = GetType().Name;
            Params = "";
        }
    }
}
