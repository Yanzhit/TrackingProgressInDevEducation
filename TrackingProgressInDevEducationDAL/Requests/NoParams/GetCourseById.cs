using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class GetCourseById:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public GetCourseById()
        {
            Type = typeof(Courses);
            Name = "GetCourseById";
            Command = "";
        }
    }
}
