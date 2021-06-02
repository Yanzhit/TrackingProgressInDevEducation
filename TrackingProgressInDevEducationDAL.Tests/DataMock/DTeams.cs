using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DTeams : ADMock
    {
        public string[] Name { get; }
        
        public DTeams()
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