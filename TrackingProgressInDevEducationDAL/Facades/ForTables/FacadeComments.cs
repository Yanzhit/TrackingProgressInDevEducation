using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeComments
    {
        
    }

    public class FacadeUpdateCommentById
    {
        public List<Comments> UpdateCommentById(int id, string text)
        {
            UpdateCommentById updateCommentById = new UpdateCommentById(id, text);
            return (List<Comments>)QuerySettings.QuerySet(updateCommentById);
        }
    }
}