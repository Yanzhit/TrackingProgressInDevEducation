namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataCType
    {
        public string[] Name { get; }

        public DataCType()
        {
            Name = DataName();
        }

        private string[] DataName()
        {
            return new[]
            {
                "Общий",
                "Soft",
                "Hard",
                "Team" //4
            };
        }
    }
}