using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyHomeworkComplete : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyHomeworkComplete()
        {
            Type = typeof(NullifyHomeworkComplete);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}
