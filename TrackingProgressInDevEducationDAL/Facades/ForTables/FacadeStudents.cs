using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.NoParams;

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
            return (List<Students>)QuerySettings.QuerySet(getStudents);
        }
    }
}