namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DCType
    {
        public string[] Name { get; }

        public DCType()
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