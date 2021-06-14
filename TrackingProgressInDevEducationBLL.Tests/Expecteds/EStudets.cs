using System.Collections;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Expecteds
{
    public class EStudets
    {
        public static IEnumerable SetNewStudent()
        {
            yield return new object[]
            {
                new SetNewStudentQ(),
                new Student
                {
                    Name = "fsdf",
                    Surname = "ttsfdft",
                    Rate = 2,
                    GroupId = 2,
                    Phone = "sdfdfsf",
                    Email = "222@sdfsdfd",
                    Contract = "sdfsdf",
                    Birthday = "fdsfds",
                    MiddleName = "1dszxczxcfdsf",
                    Git = "fsdfzxdsf",
                    CityId = 1,
                    Status = true
                },
                new SetNewStudentA("fsdf", "ttsfdft","1dszxczxcfdsf", "sdfdfsf", "fdsfds", 2, 2, "222@sdfsdfd", "sdfsdf", "fsdfzxdsf", 1, true)
            };
            yield return new object[]
            {
                new SetNewStudentQ(),
                new Student
                {
                    Name = "fsdf",
                    Surname = "ttsfdft",
                    Rate = 2,
                    GroupId = 2,
                    Phone = "sdfdfsf",
                    Email = "222@sdfsdfd",
                    Contract = "sdfsdf",
                    Birthday = "fdsfds",
                    MiddleName = "1dszxczxcfdsf",
                    Git = "fsdfzxdsf",
                    CityId = 1,
                    Status = true
                },
                new SetNewStudentA("fsdf", "ttsfdft","1dszxczxcfdsf", "sdfdfsf", "fdsfds", 2, 2, "222@sdfsdfd", "sdfsdf", "fsdfzxdsf", 1, true)
            };
        }
    }
}