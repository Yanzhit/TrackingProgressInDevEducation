using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Others
{
    public class GetAllTeamsByLector : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetAllTeamsByLector(int lectorId)
        {
            Type = typeof(Teams);
            Name = GetType().Name;
            Params = $"{lectorId}";
        }
    }
}
