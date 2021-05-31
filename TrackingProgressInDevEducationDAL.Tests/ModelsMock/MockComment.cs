using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockComment : Comment
    {
        public MockComment(string text, int typeId, int studentId, int createdBy, int teamId)
        {
            Text = text;
            TypeId = typeId;
            StudentId = studentId;
            CreatedBy = createdBy;
            TeamId = teamId;
        }
    }
}