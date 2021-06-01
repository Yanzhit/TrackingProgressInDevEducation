namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataCities
    {
        public string[] Name { get; }

        public DataCities()
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