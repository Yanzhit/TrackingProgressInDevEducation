using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyGroups : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyGroups()
        {
            Type = typeof(NullifyGroups);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}