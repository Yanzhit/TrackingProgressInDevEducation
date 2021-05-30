using System.Collections.Generic;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Requests.ForTables;
using Student = TrackingProgressInDevEducationDAL.Models.Bases.Student;

namespace TrackingProgressInDevEducationBLL.Facades.ForTables
{
    public static class FacadeStudent
    {
        private static readonly QStudent Query = new();
        public static IEnumerable<Student> GetStudents()
        {
            return (List<Student>)QuerySettings.QuerySet(Query.GetStudents());
        }

        public static IEnumerable<Student> AddNewStudent(string name, string surname, decimal rate)
        {
            return (List<Student>)QuerySettings.QuerySet(Query.AddNewStudent(name, surname, rate));
        }

        public static Student GetByIdStudent(int id)
        {
            return (Student)QuerySettings.QuerySet(Query.GetByIdStudent(id));
        }
        public static IEnumerable<Student>  NullifyStudents()
        {
            return (List<Student>)QuerySettings.QuerySet(Query.NullifyStudents());
        }
    }
}