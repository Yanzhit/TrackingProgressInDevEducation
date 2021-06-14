using System.Collections;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Models.Verification;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Expecteds
{
    public class ELectors
    {
        public static IEnumerable GetLectorByLoginAndPassword()
        {
            yield return new object[]
            {
                new GetLectorQ("Mob", "Draco"),
                new Lector
                {
                    Email = "q1@ya.ru", FullName = "Rio", Id = 3,
                    IsActivated = true, Login = "Mob", Password = "Draco"
                },
                new GetLectorA("Mob", 3, "q1qwe@ya.ru", "Rio", true)
            };
            yield return new object[]
            {
                new GetLectorQ("Web", "Draco"),
                new Lector
                {
                    Email = "q1qwe@ya.ru", FullName = "Blue Red Black", Id = 8,
                    IsActivated = false, Login = "Web", Password = "Draco"
                },
                new GetLectorA("Web", 8, "q1qwe@ya.ru", "Blue Red Black", false)
            };
        }
        public static IEnumerable SetNewLector()
        {
            yield return new object[]
            {
                new SetLectorQ("Mob", "Rio", "q1@ya.ru", "Draco"),
                new Lector
                {
                    Email = "q1@ya.ru", FullName = "Rio", Id = 3,
                    IsActivated = true, Login = "Mob", Password = "Draco"
                },
                new SetLectorA("Mob", "Rio", "q1@ya.ru", "Draco")
            };
            yield return new object[]
            {
                new SetLectorQ("Web", "Blue Red Black", "q1qwe@ya.ru", "Draco"),
                new Lector
                {
                    Email = "q1qwe@ya.ru", FullName = "Blue Red Black", Id = 8,
                    IsActivated = false, Login = "Web", Password = "Draco"
                },
                new SetLectorA("Web", "Blue Red Black", "q1qwe@ya.ru", "Draco")
            };
        }
        public static IEnumerable UpdateAcrivationLector()
        {
            yield return new object[]
            {
                new UpdLectorQ(3, true),
                new Lector
                {
                    Id = 3, IsActivated = true
                },
                new UpdLectorA(3, true)
            };
            yield return new object[]
            {
                new UpdLectorQ(2, true),
                new Lector
                {
                    Id = 2, IsActivated = true
                },
                new UpdLectorA(2, true)
            };
        }
        public static IEnumerable GetAllCurses()
        {
            yield return new object[]
            {
                new SetCoursesQ(),
                new List<Course>
                {
                    new Course()
                    {
                        Name = "3333", StartedOn = "22.21.22", Id = 4,
                        FinishedOn = "22.21.23", Description = "van"
                    },
                     new Course()
                    {
                        Name = "555555", StartedOn = "22.21.22", Id = 3,
                        FinishedOn = "22.21.23", Description = "van"
                    }
                },
                new List<SetCoursesA>()
                {
                    new SetCoursesA(4, "3333"),
                    new SetCoursesA(3, "555555")
                }
            };
            yield return new object[]
            {
                new SetCoursesQ(),
                new List<Course>
                {
                    new Course()
                    {
                        Name = "1111", StartedOn = "22.21.22", Id = 2,
                        FinishedOn = "22.21.23", Description = "van"
                    },
                     new Course()
                    {
                        Name = "222", StartedOn = "22.21.22", Id = 3,
                        FinishedOn = "22.21.23", Description = "van"
                    }
                },
                new List<SetCoursesA>()
                {
                    new SetCoursesA(2, "1111"),
                    new SetCoursesA(3, "222")
                }
            };
        }
    }
}