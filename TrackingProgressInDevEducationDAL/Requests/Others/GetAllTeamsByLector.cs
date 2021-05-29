using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Others
{
    public class GetAllTeamsByLector : IQuery
    {
        public Type Type { get; }
        public string Name { get; set; }
        public string Params { get; set; }

        public GetAllTeamsByLector(int lectorId)
        {
            Type = typeof(Team);
            Name = GetType().Name;
            Params = $"{lectorId}";
        }
    }
}
