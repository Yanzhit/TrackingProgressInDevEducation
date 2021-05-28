using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeComments
    {
        
    }

    public class FacadeGetByIdComment
    {
        public List<Comments> GetByIdComment(int id)
        {
            GetByIdComment getByIdComment = new GetByIdComment(id);
            return (List<Comments>)QuerySettings.QuerySet(getByIdComment);
        }
    }
}