using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockHomework : Homework
    {
        public MockHomework(string name)
        {
            Name = name;
        }
    }
}