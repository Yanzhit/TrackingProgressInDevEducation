using System;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DStudent
    {
        public string[] Name { get; }
        public string[] Surname { get; }
        public decimal[] Rate { get; }
        public int[] GroupId { get; }
        public string[] Phone { get; }
        public string[] Email { get; }
        public string[] Contract { get; }
        public DateTime[] Birthday { get; }
        public string[] MiddleName { get; }
        public string[] Git { get; }
        public int[] CityId { get; }

        public DStudent()
        {
            Name = DataName();
            Surname = DataSurname();
            Rate = DataRate();
            GroupId = DataGroupId();
            Phone = DataPhone();
            Email = DataEmail();
            Contract = DataContract();
            Birthday = DataBirthday();
            MiddleName = DataMiddleName();
            Git = DataGit();
            CityId = DataCityId();
        }

        private string[] DataName()
        {
            return new[]
            {
                "Вася",
                "Миша",
                "Том"
            };
        }

        private string[] DataSurname()
        {
            return new[]
            {
                "Орлов",
                "Иванов",
                "Дрозд"
            };
        }

        private decimal[] DataRate()
        {
            return new[]
            {
                10m, 100m, 21m
            };
        }

        private int[] DataGroupId()
        {
            return new[]
            {
                1, 3, 4
            };
        }

        private string[] DataPhone()
        {
            return new[]
            {
                "790677726",
                "21312412124",
                "123141412"
            };
        }

        private string[] DataEmail()
        {
            return new[]
            {
                "ffw@gmail.com",
                "wq@ya.ru",
                "w1@mail.ru"
            };
        }

        private string[] DataContract()
        {
            return new[]
            {
                "77",
                "42",
                "89"
            };
        }

        private DateTime[] DataBirthday()
        {
            return new[]
            {
                DateTime.MaxValue,
                DateTime.Now, 
                DateTime.Today
            };
        }

        private string[] DataMiddleName()
        {
            return new[]
            {
                "fwe",
                "sqw",
                "rtt"
            };
        }

        private string[] DataGit()
        {
            return new[]
            {
                "ee.ru",
                "wq.ee",
                "qw"
            };
        }

        private int[] DataCityId()
        {
            return new[]
            {
                1, 2, 3
            };
        }
    }
}