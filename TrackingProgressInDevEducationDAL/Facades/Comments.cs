using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Comments
    {
        private readonly QComment _qComments = new();
        private readonly QuerySettings _query = new();

        public Comment SetNewComment
        (
            string text,
            int typeId,
            int studentId,
            int createdBy,
            int teamId
        )
        {
            return (Comment) _query.QuerySet
            (
                _qComments.SetNewComment
                (
                    text,
                    typeId,
                    studentId,
                    createdBy,
                    teamId
                )
            );
        }

        public IEnumerable<Comment> NullifyComments()
        {
            return (List<Comment>)_query.QuerySet(_qComments.NullifyComments());
        }
    }
}