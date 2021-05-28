using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyLectors : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyLectors()
        {
            Type = typeof(Lectors);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}