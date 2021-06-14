using System.Collections;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Expecteds
{
    public class ECIties
    {
        public static IEnumerable GetCities()
        {
            yield return new object[]
            {
                new EmptyQ(),
                new List<City>()
                {

                new City()
                {
                  Name = "fdgfdg", Id = 2
                },
                 new City()
                {
                  Name = "adasdsad", Id = 3
                }
                },
                new List<GetCityA>()
                {
                    new GetCityA(2, "fdgfdg"),
                    new GetCityA(3, "adasdsad")
                }
            };
            yield return new object[]
            {
                 new EmptyQ(),
                new List<City>()
                {

                new City()
                {
                  Name = "1111", Id = 1
                },
                 new City()
                {
                  Name = "2222", Id = 4
                }
                },
                new List<GetCityA>()
                {
                    new GetCityA(1, "1111"),
                    new GetCityA(4, "2222")
                }
            };
        }
    }
}