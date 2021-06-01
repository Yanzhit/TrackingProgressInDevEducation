namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DCities
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