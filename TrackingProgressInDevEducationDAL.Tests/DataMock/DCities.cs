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
                new("СПБ"),
                new("Москва"),
                new("Владимир"),
                new("Самара"),
                new("Саратов"),
                new("Омск"),
                new("Оренбург"),
                new("Новгород"),
                new("Орск"),
                new("Тверь")
            };
        }
    }
}