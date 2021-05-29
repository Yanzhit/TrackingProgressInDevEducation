using System.Collections.Generic;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;
using Student = TrackingProgressInDevEducationDAL.Models.Bases.Student;

namespace TrackingProgressInDevEducationBLL
{
    public class FacadeExcemple
    {
        public static IEnumerable<string> GetStudents()
        {
            var result = new List<string>();
            var query = new QStudent();
            var students = (List<Student>)QuerySettings.QuerySet(query.GetStudents());
            foreach (Student student in students)
            {
                result.Add($"{student.Name} {student.Surname} {student.Rate}");
            }
            return result;
        }
    }
}