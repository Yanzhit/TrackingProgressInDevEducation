using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.NoParams;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeComments
    {
        
    }

    public class FacadeGetAllCourses
    {
        public List<Comments> GetComments()
        {
            GetComments getAllCourses = new GetComments();
            return (List<Comments>) QuerySettings.QuerySet(getAllCourses);
        }
    }
}