namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DTeam
    {
        public string[] Name { get; }
        
        public DTeam()
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