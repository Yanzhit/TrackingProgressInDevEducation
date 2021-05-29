using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Tests.DataMock;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class MockBase
    {
        public List<DataComments> Comments { get; }
        public List<DataCommentType> CommentType { get; }
        public List<DataGroups> Groups { get; }
        public List<DataCourses> Courses { get; }
        public List<DataLectors> Lectors { get; }
        public List<DataPayments> Payments { get; }
        public List<DataStudents> Students { get; }
        public List<DataTeams> Teams { get; }
        public List<DataVisits> Visits { get; }

        public MockBase()
        {
            Comments = new List<DataComments>();
            CommentType = new List<DataCommentType>();
            Groups = new List<DataGroups>();
            Courses = new List<DataCourses>();
            Lectors = new List<DataLectors>();
            Payments = new List<DataPayments>();
            Students = new List<DataStudents>();
            Teams = new List<DataTeams>();
            Visits = new List<DataVisits>();
        }
    }
}