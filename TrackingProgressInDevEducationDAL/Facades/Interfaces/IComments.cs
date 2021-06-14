using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface IComments
    {
        Comment SetNewComment(Comment comment);
        Comment SetNewCommentToStudent(Comment comment);
        Comment SetCommentToTeam(Comment comment);
        IEnumerable<Comment> GetCommentsByStudent(Comment comment);
        IEnumerable<Comment> GetCommentsByTeam();
        IEnumerable<Comment> NullifyComments();
    }
}