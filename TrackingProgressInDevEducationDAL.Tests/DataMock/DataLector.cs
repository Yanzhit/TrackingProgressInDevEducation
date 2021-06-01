namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataLector
    {
        public string[] FullName { get; }
        public string[] Email { get; }
        public string[] Password { get; }

        public DataLector()
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