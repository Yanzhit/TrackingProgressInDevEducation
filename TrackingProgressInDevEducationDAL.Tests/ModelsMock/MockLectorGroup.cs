using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockLectorGroup : LectorGroup
    {
        public MockLectorGroup(int lectorId, int groupId)
        {
            LectorId = lectorId;
            GroupId = groupId;
        }
    }
}