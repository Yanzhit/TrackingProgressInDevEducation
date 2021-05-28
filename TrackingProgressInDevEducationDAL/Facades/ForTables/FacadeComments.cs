using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeComments
    {
        
    }

    public class FacadeRemoveCommentById
    {
        public List<Comments> RemoveCommentById(int id)
        {
            RemoveCommentById removeCommentById = new RemoveCommentById(id);
            return (List<Comments>) QuerySettings.QuerySet(removeCommentById);
        }
    }
}