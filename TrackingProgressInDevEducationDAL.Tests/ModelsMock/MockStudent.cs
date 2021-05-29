using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockStudent : Student
    {
        public MockStudent(string name, string surname, decimal rate)
        {
            Name = name;
            Surname = surname;
            Rate = rate;
        }
    }
}