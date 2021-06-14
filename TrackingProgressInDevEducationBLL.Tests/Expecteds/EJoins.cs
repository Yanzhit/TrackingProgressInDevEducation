using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationBLL.Models.Course;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Tests.Expecteds
{
    public class EJoins
    {
        public static IEnumerable SetNewGroup()
        {
            yield return new object[]
            {
                new SetGroupQ(),
                new SetNewGroupJ
                {
                     Name = "Name",
                    CourseId = 1,
                    StartDate = "22.21.22",
                    EndDate = "22.22.22"
                },
                new SetGroupA("Name", 1, "22.21.22", "22.22.22")
            };
            yield return new object[]
            {
                new SetGroupQ(),
                new SetNewGroupJ
                {
                     Name = "Name11",
                    CourseId = 1,
                    StartDate = "22.21.21",
                    EndDate = "22.22.23"
                },
                new SetGroupA("Name11", 1, "22.21.21", "22.22.23")
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