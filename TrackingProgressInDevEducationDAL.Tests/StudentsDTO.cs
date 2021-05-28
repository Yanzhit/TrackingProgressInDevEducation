using System.Collections;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables.Students;
using TrackingProgressInDevEducationDAL.Requests.NoParams;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class StudentsDTO : IEnumerable
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
                        Name = "Тимур",
                        Surname = "Кот",
                        Rate = 100.00m
                    },
                    new()
                    {
                        Name = "Шерхан",
                        Surname = "Тигр",
                        Rate = 100.00m
                    },
                    new()
                    {
                        Name = "Убийца",
                        Surname = "Киви",
                        Rate = 100.00m
                    },
                    new()
                    {
                        Name = "Синий",
                        Surname = "Клен",
                        Rate = 100.00m
                    },
                    new()
                    {
                        Name = "Радостная",
                        Surname = "Прелесть",
                        Rate = 10.00m
                    },
                    new()
                    {
                        Name = "Жидкий",
                        Surname = "Лес",
                        Rate = 67.00m
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