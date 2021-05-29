using System;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockCourses : Courses
    {
        public MockCourses(string name, DateTime startedOn, DateTime finishedOn)
        {
            Name = name;
            StartedOn = startedOn;
            FinishedOn = finishedOn;
        }
    }
}