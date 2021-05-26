using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class RemoveCourseById:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public RemoveCourseById()
        {
            Type = typeof(Courses);
            Name = "RemoveCourseById";
            Command = "";
        }
    }
}
