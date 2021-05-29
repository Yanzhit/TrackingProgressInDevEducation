using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockCommentType : CommentType
    {
        public MockCommentType(string name)
        {
            Name = name;
        }
    }
}