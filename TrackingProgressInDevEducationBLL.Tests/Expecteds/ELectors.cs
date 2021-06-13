using System.Collections;
using TrackingProgressInDevEducationBLL.Models.SignIn;
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
    }
}