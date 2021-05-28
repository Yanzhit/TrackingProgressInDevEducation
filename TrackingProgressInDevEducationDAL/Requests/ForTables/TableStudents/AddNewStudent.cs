using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableStudents
{
    public class AddNewStudent : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewStudent(string name, string surname, decimal rate)
        {
            Type = typeof(Models.Bases.Students);
            Name = GetType().Name;
            Params = $"{name}, {surname}, {rate}";
        }
    }
}