using System.Collections;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.NoParams;

namespace TrackingProgressInDevEducationDAL.Tests
{
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