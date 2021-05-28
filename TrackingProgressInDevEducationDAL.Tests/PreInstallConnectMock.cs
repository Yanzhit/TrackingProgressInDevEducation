using System.Collections.Generic;
using System.Diagnostics;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Nullify;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public static class PreInstallConnectMock
    {
        public static List<T> GetMock<T>(List<T> t)
        {
            NullifyStudents nullifyStudents = new NullifyStudents();
            QuerySettings.QuerySet(nullifyStudents);
            switch (t.Count)
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

            return new List<T>();
        }
    }
}