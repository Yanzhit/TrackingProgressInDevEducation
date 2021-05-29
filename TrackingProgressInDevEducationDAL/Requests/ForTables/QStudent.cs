using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QStudent : IQuery
    {
        public Type Type { get; } = typeof(Student);
        public string Name { get; set; }
        public string Params { get; set; }

        public QStudent AddNewStudent(string name, string surname, decimal rate)
        {
            Name = nameof(AddNewStudent);
            Params = $"{name}, {surname}, {rate}";
            return this;
        }

        public QStudent GetStudents()
        {
            Name = nameof(GetStudents);
            Params = string.Empty;
            return this;
        }
        public QStudent GetByIdStudent(int id)
        {
            Name = nameof(GetByIdStudent);
            Params = $"{id}";
            return this;
        }
        public QStudent NullifyStudents()
        {
            Name = nameof(NullifyStudents);
            Params = string.Empty;
            return this;
        }
    }
}