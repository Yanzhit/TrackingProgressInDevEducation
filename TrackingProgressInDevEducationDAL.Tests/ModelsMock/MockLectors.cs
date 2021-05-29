using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockLectors : Lectors
    {
        public MockLectors(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
        }
    }
}