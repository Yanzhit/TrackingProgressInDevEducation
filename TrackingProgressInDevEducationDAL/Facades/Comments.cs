using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstarcts;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Comments : AFacade
    {
        public QComment Query { get; set; }
        public Comment SetNewComment
        (
            string text,
            int typeId,
            int studentId,
            int createdBy,
            int teamId
        )
        {
            return (Comment) _querySet.QuerySet
            (
                Query.SetNewComment
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
            return (List<Comment>)_querySet.QuerySet(Query.NullifyComments());
        }
    }
}