using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockGroups : Groups
    {
        public MockGroups(string name, int courseId)
        {
            Name = name;
            CourseId = courseId;
        }
    }
}