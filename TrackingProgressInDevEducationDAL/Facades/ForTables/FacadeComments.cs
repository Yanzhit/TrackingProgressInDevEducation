using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.NoParams;
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

    public class FacadeAddNewComment
    {
        public List<Comments> AddNewComment(string text, int typeId, int studentId, int createdBy)
        {
            AddNewComment addNewComment = new AddNewComment(text, typeId, studentId, createdBy);
            return (List<Comments>) QuerySettings.QuerySet(addNewComment);
        }
    }

    public class FacadeGetComments
    {
        public List<Comments> GetComments()
        {
            GetComments getAllCourses = new GetComments();
            return (List<Comments>) QuerySettings.QuerySet(getAllCourses);
        }
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