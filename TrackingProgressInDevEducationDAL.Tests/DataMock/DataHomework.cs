namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataHomework
    {
        public string[] Name { get; }
        public string[] Deskription { get; }

        public DataHomework()
        {
            Name = DataName();
            Deskription = DataDeskription();
        }

        private string[] DataName()
        {
            return new[]
            {
                "ff",
                "qq"
            };
        }

        private string[] DataDeskription()
        {
            return new[]
            {
                "rr",
                "tt"
            };
        }
    }
}