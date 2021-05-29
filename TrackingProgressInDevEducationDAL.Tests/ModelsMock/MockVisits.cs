using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockVisits : Visits
    {
        public MockVisits(bool visitStatus, int studentId, int lectionId)
        {
            VisitStatus = visitStatus;
            StudentId = studentId;
            LectionId = lectionId;
        }
    }
}