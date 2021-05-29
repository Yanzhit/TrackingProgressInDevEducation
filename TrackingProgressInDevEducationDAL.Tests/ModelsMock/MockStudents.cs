using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockStudents : Students
    {
        public MockStudents(string name, string surname, decimal rate)
        {
            Name = name;
            Surname = surname;
            Rate = rate;
        }
    }
}