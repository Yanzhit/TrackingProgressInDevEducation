using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
   public class GetVisits : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetVisits()
        {
            Type = typeof(Visits);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}
