using System;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DGroups : ADMock
    {
        public string[] Name { get; }
        public int[] CourseId { get; }
        public DateTime[] StartDate { get; }
        public DateTime[] EndDate { get; }

        public DGroups()
        {
            Name = DataName();
            CourseId = DataCourseId();
            StartDate = DataStartDate();
            EndDate = DataEndDate();
        }

        private string[] DataName()
        {
            return new[]
            {
                "Dev{ed} C# Base 1",
                "Dev{ed} C# Base 2",
                "Dev{ed} C# Base 3",
                "Dev{ed} C# Base 4",
                "Dev{ed} C# Base 5",
                "Dev{ed} C# Base 6",
                "Dev{ed} C# Base 7",
                "Dev{ed} C# Base 8"
            };
        }

        private int[] DataCourseId()
        {
            return new[] {1, 1, 1, 1, 1, 1, 1, 1};
        }

        private DateTime[] DataStartDate()
        {
            return new[]
            {
                DateTime.MaxValue, 
                DateTime.MinValue,
                DateTime.Now,
                DateTime.MaxValue,
                DateTime.MaxValue, 
                DateTime.MinValue,
                DateTime.Now,
                DateTime.MaxValue
            };
        }
        private DateTime[] DataEndDate()
        {
            return new[]
            {
                DateTime.MaxValue, 
                DateTime.MinValue,
                DateTime.Now,
                DateTime.MaxValue,
                DateTime.MaxValue, 
                DateTime.MinValue,
                DateTime.Now,
                DateTime.MaxValue
            };
        }
    }
}