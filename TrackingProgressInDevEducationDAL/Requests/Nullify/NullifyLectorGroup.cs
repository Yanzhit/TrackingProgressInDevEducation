using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyLectorGroup : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyLectorGroup()
        {
            Type = typeof(NullifyLectorGroup);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}