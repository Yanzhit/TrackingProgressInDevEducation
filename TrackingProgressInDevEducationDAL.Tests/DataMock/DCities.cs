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
                new(new object[] {"СПБ"}),
                new(new object[] {"Москва"}),
                new(new object[] {"Владимир"}),
                new(new object[] {"Самара"}),
                new(new object[] {"Саратов"}),
                new(new object[] {"Омск"}),
                new(new object[] {"Оренбург"}),
                new(new object[] {"Новгород"}),
                new(new object[] {"Орск"}),
                new(new object[] {"Тверь"})
            };
        }
    }
}