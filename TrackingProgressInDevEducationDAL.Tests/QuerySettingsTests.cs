using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class QuerySettingsTests
    {
        public class ReverseTestsTests
        {
            [TestCaseSource(typeof(ConnectionDTO))]
            public void GetStudentsTest(IQuery query, List<Students> expected)
            {
                List<Students> actual = (List<Students>)QuerySettings.QuerySet(query);
                Assert.AreEqual(expected, actual);
            }
        }
        public class ConnectionDTO : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]
                {
                    new GetStudents(),

                    new List<Students>
                    {
                        new()
                        {
                            Name = "Имя",
                            Surname = "Фамилия",
                            Rate = 0.0m
                        },
                        new()
                        {
                            Name = "Имя",
                            Surname = "Фамилия",
                            Rate = 0.0m
                        },
                        new()
                        {
                            Name = "Имя",
                            Surname = "Фамилия",
                            Rate = 0.0m
                        }
                    }
                };
                //yield return new object[] {
                    
                //};
                //yield return new object[] {
                    
                //};
            }
        }
    }
}