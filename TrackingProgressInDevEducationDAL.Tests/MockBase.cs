using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class MockBase
    {
        public List<City> Cities { get; }
        public List<Comment> Comments { get; }
        public List<CommentType> CommentTypes { get; }
        public List<Course> Courses { get; }
        public List<Group> Groups { get; }
        public List<Homework> Homeworks { get; }
        public List<HWComplete> HWCompletes { get; }
        public List<HWGroup> HWGroups { get; }
        public List<Lection> Lections { get; }
        public List<Lector> Lectors { get; }
        public List<LectorCourse> LectorCourses { get; }
        public List<LectorGroup> LectorGroups { get; }
        public List<Payment> Payments { get; }
        public List<Student> Students { get; }
        public List<Team> Teams { get; }
        public List<TeamStudent> TeamStudents { get; }
        public List<Visit> Visits { get; }


        public MockBase()
        {
            Cities = new List<City>();
            Comments = new List<Comment>();
            CommentTypes = new List<CommentType>();
            Courses = new List<Course>();
            Groups = new List<Group>();
            Homeworks = new List<Homework>();
            HWCompletes = new List<HWComplete>();
            HWGroups = new List<HWGroup>();
            Lections = new List<Lection>();
            Lectors = new List<Lector>();
            LectorCourses = new List<LectorCourse>();
            LectorGroups = new List<LectorGroup>();
            Payments = new List<Payment>();
            Students = new List<Student>();
            Teams = new List<Team>();
            TeamStudents = new List<TeamStudent>();
            Visits = new List<Visit>();
        }
    }
}