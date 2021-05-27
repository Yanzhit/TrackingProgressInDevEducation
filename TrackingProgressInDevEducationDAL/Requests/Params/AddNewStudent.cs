using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class AddNewStudent : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewStudent(string name, string surname, decimal rate)
        {
            Type = typeof(Students);
            Name = "AddNewStudent";
            Params = $"{name}, {surname}, {rate}";
        }
    }
}