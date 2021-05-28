using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeComments
    {
        
    }

    public class FacadeAddNewComment
    {
        public List<Comments> AddNewComment(string text, int typeId, int studentId, int createdBy)
        {
            AddNewComment addNewComment = new AddNewComment(text, typeId, studentId, createdBy);
            return (List<Comments>) QuerySettings.QuerySet(addNewComment);
        }
    }
}