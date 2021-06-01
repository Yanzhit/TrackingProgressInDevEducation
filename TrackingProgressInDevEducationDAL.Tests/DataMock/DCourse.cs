using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DCourse : ADMock
    {
        public string[] Name { get; }

        public DCourse()
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