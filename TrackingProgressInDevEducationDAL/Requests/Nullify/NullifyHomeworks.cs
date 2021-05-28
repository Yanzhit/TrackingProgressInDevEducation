using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
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
            Type = typeof(Homeworks);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}