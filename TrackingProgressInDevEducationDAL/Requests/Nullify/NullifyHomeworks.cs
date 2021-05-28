using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyHomeworks : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyHomeworks()
        {
            Type = typeof(NullifyHomeworks);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}