using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DLectors : ADMock
    {
        public string[] FullName { get; }
        public string[] Email { get; }
        public string[] Password { get; }

        public DLectors()
        {
            FullName = DataFullName();
            Email = DataEmail();
            Password = DataPassword();
        }

        private string[] DataFullName()
        {
            return new[]
            {
                "ABH",
                "DQQ",
                "WEe"
            };
        }
        
        private string[] DataEmail()
        {
            return new[]
            {
                
                "DQQ",
                "ABH",
                "WEe"
            };
        }
        
        private string[] DataPassword()
        {
            return new[]
            {
                "WEe",
                "ABH",
                "DQQ"
            };
        }
    }
}