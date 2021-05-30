using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QStudent : IQuery
    {
        public Type Type { get; } = typeof(Student);
        public string Schema { get; set; } = $"exec TrackingProgressInDevEducationDB.";
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QStudent AddNewStudent(string name, string surname, decimal rate)
        {
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(AddNewStudent);
            Params = $"{name}, {surname}, {rate}";
            return this;
        }

        public QStudent GetStudents()
        {
            TypeQueries = TypeQueries.GetSeveral;
            Name = nameof(GetStudents);
            Params = string.Empty;
            return this;
        }
        public QStudent GetByIdStudent(int id)
        {
            TypeQueries = TypeQueries.GetOne;
            Name = nameof(GetByIdStudent);
            Params = $"{id}";
            return this;
        }
        public QStudent NullifyStudents()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyStudents);
            Params = string.Empty;
            return this;
        }
    }
}