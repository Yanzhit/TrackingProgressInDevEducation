namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataCourse
    {
        public string[] Name { get; }

        public DataCourse()
        {
            Name = DataName();
        }

        private string[] DataName()
        {
            return new[]
            {
                "C# - default",
                "C# - Front",
                "C# - Back",
                "C# - Mobile",
                "Java - default",
                "Java - Front",
                "Java - Back",
                "Java - Mobile" // 8
            };
        }
    }
}