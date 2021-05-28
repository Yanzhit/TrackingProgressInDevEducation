using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;
using static System.String;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyCourses : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyCourses()
        {
            Type = typeof(NullifyCourses);
            Name = GetType().Name;
            Params = Empty;
        }
    }
}