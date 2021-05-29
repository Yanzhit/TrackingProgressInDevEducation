using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockHomeworkGroup : HomeworkGroup
    {
        public MockHomeworkGroup(int homeworkId, int groupId)
        {
            HomeworkId = homeworkId;
            GroupId = groupId;
        } 
    }
}