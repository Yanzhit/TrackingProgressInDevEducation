using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Tests.ModelsMock;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class MockBase
    {
        public List<MockComment> Comments { get; }
        public List<MockCommentType> CommentType { get; }
        public List<MockGroup> Groups { get; }
        public List<MockCourse> Courses { get; }
        public List<MockLector> Lectors { get; }
        public List<MockPayment> Payments { get; }
        public List<MockStudent> Students { get; }
        public List<MockTeam> Teams { get; }
        public List<MockVisit> Visits { get; }

        public MockBase()
        {
            Comments = new List<MockComment>();
            CommentType = new List<MockCommentType>();
            Groups = new List<MockGroup>();
            Courses = new List<MockCourse>();
            Lectors = new List<MockLector>();
            Payments = new List<MockPayment>();
            Students = new List<MockStudent>();
            Teams = new List<MockTeam>();
            Visits = new List<MockVisit>();
        }
    }
}