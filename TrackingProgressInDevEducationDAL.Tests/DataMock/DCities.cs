using System.Collections;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DCities : ADMock
    {
        public string[] Name { get; }

        public DCities()
        {
            Name = DataName();
        }

        private string[] DataName()
        {
            return new[]
            {
                "Санкт-Петербург",
                "Москва",
                "Владимир",
                "Самара",
                "Саратов",
                "Омск",
                "Оренбург",
                "Новгород",
                "Орск",
                "Тверь" //10
            };
        }
    }
}