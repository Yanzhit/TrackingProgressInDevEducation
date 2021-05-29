using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockLection : Lection
    {
        public MockLection(int courseId, int lectorId, string startedOn)
        {
            CourseId = courseId;
            LectorId = lectorId;
            StartedOn = startedOn;
        }
    }
}