using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests
{
    public class AddNewStudent : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewStudent(string Name, string Surname, decimal Rate)
        {
            Type = typeof(Students);
            Name = "AddNewStudent";
            Params = $"{Name},{Surname},{Rate}";
        }
    }
}