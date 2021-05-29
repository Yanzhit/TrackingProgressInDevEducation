using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataGroups
    {
        public string Name { get; }
        public int CourseId { get; }

        public DataGroups(string name, int courseId)
        {
            Name = name;
            CourseId = courseId;
        }
    }
}