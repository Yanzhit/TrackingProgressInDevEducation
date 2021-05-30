using System;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockCourse : Course
    {
        public MockCourse(string name, DateTime startedOn, DateTime finishedOn)
        {
            Name = name;
            StartedOn = startedOn;
            FinishedOn = finishedOn;
        }
    }
}