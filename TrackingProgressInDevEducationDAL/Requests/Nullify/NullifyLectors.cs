using System;
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
            Type = typeof(NullifyLectors);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}