using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class GetAllCourses:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public GetAllCourses()
        {
            Type = typeof(Courses);
            Name = "GetAllCourses";
            Command = "";
        }
    }
}
