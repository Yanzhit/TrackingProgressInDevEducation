namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataCommentType
    {
        public string[] Name { get; }

        public DataCommentType()
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