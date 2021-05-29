using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockLections : Lections
    {
        public MockLections(int courseId, int lectorId, string startedOn)
        {
            CourseId = courseId;
            LectorId = lectorId;
            StartedOn = startedOn;
        }
    }
}