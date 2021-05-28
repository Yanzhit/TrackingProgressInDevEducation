using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyHomeworkGroup : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyHomeworkGroup()
        {
            Type = typeof(NullifyHomeworkGroup);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}