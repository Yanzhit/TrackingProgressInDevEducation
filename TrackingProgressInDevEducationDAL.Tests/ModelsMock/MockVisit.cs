using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockVisit : Visit
    {
        public MockVisit(bool visitStatus, int studentId, int lectionId)
        {
            VisitStatus = visitStatus;
            StudentId = studentId;
            LectionId = lectionId;
        }
    }
}