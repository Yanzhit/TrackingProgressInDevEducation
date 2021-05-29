using System.Collections.Generic;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationBLL.Facades.ForTables
{
    public static class FacadeComments
    {
        private static readonly QComment Query = new();
        public static IEnumerable<Comment> UpdateCommentById(int id, string text)
        {
            return (List<Comment>) QuerySettings.QuerySet(Query.UpdateCommentById(id, text));
        }
        public static IEnumerable<Comment> RemoveCommentById(int id)
        {
            return (List<Comment>) QuerySettings.QuerySet(Query.RemoveCommentById(id));
        }
        public static IEnumerable<Comment> AddNewComment(string text, int typeId, int studentId, int createdBy)
        {
            return (List<Comment>) QuerySettings.QuerySet(Query.AddNewComment(text, typeId, studentId, createdBy));
        }
        public static IEnumerable<Comment> GetComments()
        {
            return (List<Comment>) QuerySettings.QuerySet(Query.GetComments());
        }
        public static IEnumerable<Comment> GetByIdComment(int id)
        {
            return (List<Comment>)QuerySettings.QuerySet(Query.GetByIdComment(id));
        }
    }
}