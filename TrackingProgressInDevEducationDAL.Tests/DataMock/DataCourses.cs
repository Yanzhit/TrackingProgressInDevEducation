using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataCourses
    {
        public string Name { get; }
        public DateTime StartedOn { get; }
        public DateTime FinishedOn { get; }

        public DataCourses(string name, DateTime startedOn, DateTime finishedOn)
        {
            Name = name;
            StartedOn = startedOn;
            FinishedOn = finishedOn;
        }
    }
}