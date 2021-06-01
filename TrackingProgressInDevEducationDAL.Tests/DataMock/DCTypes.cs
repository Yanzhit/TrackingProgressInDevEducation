using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DCTypes : ADMock
    {
        public string[] Name { get; }

        public DCTypes()
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