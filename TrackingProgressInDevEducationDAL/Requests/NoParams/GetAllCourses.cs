using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class GetAllCourses : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetAllCourses()
        {
            Type = typeof(Courses);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}
