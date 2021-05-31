using System.Collections.Generic;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationBLL.Facades.ForTables
{
    public static class FacadeComments
    {
        private static readonly QComment Query = new();
        //public static IEnumerable<Comment> UpdateCommentById(int id, string text)
        //{
        //    return (List<Comment>) QuerySettings.QuerySet(Query.UpdateCommentById(id, text));
        //}
        //public static IEnumerable<Comment> RemoveCommentById(int id)
        //{
        //    return (List<Comment>) QuerySettings.QuerySet(Query.RemoveCommentById(id));
        //}
        public static IEnumerable<Comment> SetNewComment(string text, int typeId, int studentId, int createdBy, int teamId)
        {
            return (List<Comment>) QuerySettings.QuerySet(Query.SetNewComment(text, typeId, studentId, createdBy, teamId));
        }
        //public static IEnumerable<Comment> GetAllComments()
        //{
        //    return (List<Comment>) QuerySettings.QuerySet(Query.GetAllComments());
        //}
        //public static IEnumerable<Comment> GetByIdComment(int id)
        //{
        //    return (List<Comment>)QuerySettings.QuerySet(Query.GetByIdComment(id));
        //}
    }
}