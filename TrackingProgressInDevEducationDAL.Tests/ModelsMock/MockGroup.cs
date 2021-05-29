using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockGroup : Group
    {
        public MockGroup(string name, int courseId)
        {
            Name = name;
            CourseId = courseId;
        }
    }
}