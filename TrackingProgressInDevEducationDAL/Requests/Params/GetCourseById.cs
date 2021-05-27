using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class GetCourseById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetCourseById(int id)
        {
            Type = typeof(Courses);
            Name = "GetCourseById";
            Params = $"{id}";
        }
    }
}
