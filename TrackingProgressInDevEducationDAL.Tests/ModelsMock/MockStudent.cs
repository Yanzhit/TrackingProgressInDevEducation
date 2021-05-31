using System;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockStudent : Student
    {
        public MockStudent
            (
            string name,
            string surname,
            decimal rate,
            int groupId,
            string phone,
            string email,
            string contract,
            DateTime birthday,
            string middleName,
            string git,
            int cityId,
            bool status
            )
        {
            Name = name;
            Surname = surname;
            Rate = rate;
            GroupId = groupId;
            Phone = phone;
            Email = email;
            Contract = contract;
            Birthday = birthday;
            MiddleName = middleName;
            Git = git;
            CityId = cityId;
            Status = status;
        }
    }
}