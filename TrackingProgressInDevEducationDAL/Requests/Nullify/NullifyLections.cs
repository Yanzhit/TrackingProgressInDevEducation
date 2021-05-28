using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyLections : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyLections()
        {
            Type = typeof(NullifyLections);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}