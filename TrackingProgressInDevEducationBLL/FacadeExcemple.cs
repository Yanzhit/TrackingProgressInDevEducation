using System.Collections.Generic;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables.TableStudents;

namespace TrackingProgressInDevEducationBLL
{
    public class FacadeExcemple
    {
        public static IEnumerable<string> GetStudents()
        {
            var result = new List<string>();
            GetStudents getStudents = new GetStudents();
            var students = (List<Students>)QuerySettings.QuerySet(getStudents);
            foreach (Students student in students)
            {
                result.Add($"{student.Name} {student.Surname} {student.Rate}\n");
            }
            return result;
        }
    }
}