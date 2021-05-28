using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeStudents
    {
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