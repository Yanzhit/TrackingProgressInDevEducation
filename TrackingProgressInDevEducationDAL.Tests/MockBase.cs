using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Tests.ModelsMock;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class MockBase
    {
        public List<MockComments> Comments { get; }
        public List<MockCommentType> CommentType { get; }
        public List<MockGroups> Groups { get; }
        public List<MockCourses> Courses { get; }
        public List<MockLectors> Lectors { get; }
        public List<MockPayments> Payments { get; }
        public List<MockStudents> Students { get; }
        public List<MockTeams> Teams { get; }
        public List<MockVisits> Visits { get; }

        public MockBase()
        {
            Comments = new List<MockComments>();
            CommentType = new List<MockCommentType>();
            Groups = new List<MockGroups>();
            Courses = new List<MockCourses>();
            Lectors = new List<MockLectors>();
            Payments = new List<MockPayments>();
            Students = new List<MockStudents>();
            Teams = new List<MockTeams>();
            Visits = new List<MockVisits>();
        }
    }
}