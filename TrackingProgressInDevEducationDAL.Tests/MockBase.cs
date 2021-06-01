using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class MockBase
    {
        public List<Comment> Comments { get; }
        public List<CommentType> CommentType { get; }
        public List<Group> Groups { get; }
        public List<Course> Courses { get; }
        public List<Lector> Lectors { get; }
        public List<Payment> Payments { get; }
        public List<Student> Students { get; }
        public List<Team> Teams { get; }
        public List<Visit> Visits { get; }

        public MockBase()
        {
            Comments = new List<Comment>();
            CommentType = new List<CommentType>();
            Groups = new List<Group>();
            Courses = new List<Course>();
            Lectors = new List<Lector>();
            Payments = new List<Payment>();
            Students = new List<Student>();
            Teams = new List<Team>();
            Visits = new List<Visit>();
        }
    }
}