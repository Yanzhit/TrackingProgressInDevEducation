using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.DataMock;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class MockBase
    {
        /// <summary>
        /// 
        /// </summary>
        public List<DCities> Cities => new();
        public List<Comment> Comments => new();
        public List<CType> CTypes => new();
        public List<Course> Courses => new();
        public List<Group> Groups => new();
        public List<Homework> Homeworks => new();
        public List<HWComplete> HWCompletes => new();
        public List<HWGroup> HWGroups => new();
        public List<Lection> Lections => new();
        public List<Lector> Lectors  => new();
        public List<LectorCourse> LectorCourses => new();
        public List<LectorGroup> LectorGroups => new();
        public List<Payment> Payments  => new();
        public List<Student> Students => new();
        public List<Team> Teams  => new();
        public List<TeamStudent> TeamStudents => new();
        public List<Visit> Visits  => new();
    }
}