namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataTeam
    {
        public string[] Name { get; }
        
        public DataTeam()
        {
            Name = DataName();
        }
        private string[] DataName()
        {
            return new[]
            {
                "eeee",
                "ttete",
                "twqeqwe"
            };
        }
    }
}