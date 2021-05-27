using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;
namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class GetAllTeamsByLector : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetAllTeamsByLector(int LectorId)
        {
            Type = typeof(Teams);
            Name = "GetAllTeamsByLector";
            Params = $"{LectorId}";
        }
    }
}
