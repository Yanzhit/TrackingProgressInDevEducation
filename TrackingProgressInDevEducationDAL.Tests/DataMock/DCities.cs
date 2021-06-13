using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База Городов
    /// </summary>
    public class DCities : ADMock
    {
        /// <summary>
        /// Список городов для заполнения BD
        /// </summary>
        public List<City> Cities { get; }

        /// <summary>
        /// Инициализация базы городов
        /// </summary>
        public DCities()
        {
            Cities = new List<City>
            {
                new City {Name ="СПБ"},
                new City {Name ="Москва"},
                new City {Name ="Владимир"},
                new City {Name ="Самара"},
                new City {Name ="Саратов"},
                new City {Name ="Омск"},
                new City {Name ="Оренбург"},
                new City {Name ="Новгород"},
                new City {Name ="Орск"},
                new City {Name ="Тверь"}
            };
        }
    }
}