using System.Collections.Generic;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables.TableComments;

namespace TrackingProgressInDevEducationBLL.Facades.ForTables
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