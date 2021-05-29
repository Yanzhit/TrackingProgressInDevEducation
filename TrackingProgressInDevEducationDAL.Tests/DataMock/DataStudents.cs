using System;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataStudents
    {
        public string Name { get; }
        public string Surname { get;}
        public decimal Rate { get; }

        public DataStudents(string name, string surname, decimal rate)
        {
            Name = name;
            Surname = surname;
            Rate = rate;
        }
    }
}