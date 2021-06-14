using System.Collections;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models.Course;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Expecteds
{
    public class ECourses
    {
        public static IEnumerable SetNewCourse()
        {
            yield return new object[]
            {
                new SetNewCoursesQ(),
                new Course
                {
                    Name = "sssss",
                    Description = "eeee"
                },
                new SetNewCoursesA("sssss")
            };
            yield return new object[]
            {
                new SetNewCoursesQ(),
                new Course
                {
                     Name = "eeee",
                    Description = "ssss"
                },
                new SetNewCoursesA("eeee")
            };
        }
        public static IEnumerable GetAllCurses()
        {
            yield return new object[]
            {
                new SetCoursesQ(),
                new List<Course>()
                {

                new Course()
                {
                  Name = "fdgfdg", Id = 2
                },
                 new Course()
                {
                  Name = "adasdsad", Id = 3
                }
                },
                new List<SetCoursesA>()
                {
                    new SetCoursesA(2, "fdgfdg"),
                    new SetCoursesA(3, "adasdsad")
                }
            };
            yield return new object[]
            {
                new SetCoursesQ(),
                new List<Course>()
                {

                new Course()
                {
                  Name = "1111", Id = 1
                },
                 new Course()
                {
                  Name = "2222", Id = 4
                }
                },
                new List<SetCoursesA>()
                {
                    new SetCoursesA(1, "1111"),
                    new SetCoursesA(4, "2222")
                }
            };
        }
    }
}