using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.NoParams;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeStudents
    {
    }

    public class FacadeGetStudents
    {
        public List<Students> GetStudents()
        {
            GetStudents getStudents = new GetStudents();
            return (List<Students>) QuerySettings.QuerySet(getStudents);
        }
    }

    public class FacadeAddNewStudent
    {
        public string AddNewStudent(string name, string surname, decimal rate)
        {
            AddNewStudent addNewStudent = new AddNewStudent(name, surname, rate);
            return (string) QuerySettings.QuerySet(addNewStudent);
        }
    }

    public class FacadeGetByIdStudent
    {
        public List<Students> GetByIdStudent(int id)
        {
            GetByIdStudent getByIdStudent = new GetByIdStudent(id);
            return (List<Students>) QuerySettings.QuerySet(getByIdStudent);
        }
    }
}