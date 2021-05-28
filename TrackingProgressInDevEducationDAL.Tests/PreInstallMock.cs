using System.Collections.Generic;
using System.Diagnostics;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.NoParams;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class PreInstallMock
    {
        public void Mock(int i)
        {
            NullifyStudents nullifyStudents = new NullifyStudents();
            QuerySettings.QuerySet(nullifyStudents);
            switch (i)
            {
                case 1:
                    new List<Students>
                    {
                        new()
                        {
                            Name = "Имя",
                            Surname = "Фамилия",
                            Rate = 0.0m
                        },
                        new()
                        {
                            Name = "Имя",
                            Surname = "Фамилия",
                            Rate = 0.0m
                        },
                        new()
                        {
                            Name = "Имя",
                            Surname = "Фамилия",
                            Rate = 0.0m
                        }
                    };
                    break;
            }
        }
    }
}