using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class GetLectors : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetLectors()
        {
            Type = typeof(Lectors);
            Name = GetType().Name;
            Params = "";
        }
    }
}
