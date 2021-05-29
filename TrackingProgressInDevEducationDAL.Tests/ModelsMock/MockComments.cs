using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockComments : Comments
    {
        public MockComments(string text, int typeId, int studentId, int createdBy)
        {
            Text = text;
            TypeId = typeId;
            StudentId = studentId;
            CreatedBy = createdBy;
        }
    }
}