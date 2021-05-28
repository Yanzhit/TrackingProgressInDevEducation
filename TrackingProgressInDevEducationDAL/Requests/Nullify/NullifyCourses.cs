using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyCourses : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyCourses()
        {
            Type = typeof(Courses);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}