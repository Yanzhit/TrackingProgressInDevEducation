using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationBLL.Models.Course;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Expecteds
{
    public class EJoins
    {
        public static IEnumerable SetNewGroup()
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
        public static IEnumerable GetGroupByIdJ()
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
        public static IEnumerable GetGroupsByLectorJ()
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
        public static IEnumerable GetAllStudentsByGroup()
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
        public static IEnumerable GetAllCoursesByGroup()
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
        public static IEnumerable GetAllTeamsByLectorJ()
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
        public static IEnumerable GetAllStudents()
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
        public static IEnumerable GetVisitsByStudentJ()
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
    }
}