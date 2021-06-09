using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class CommentsFor : AFacade
    {
        private readonly QCommentFor _query = new();
    
        public CommentFor SetNewCFor()
        {
            return (CommentFor)Manager.Setter.Single(_query.SetNewCFor());
        }

        public IEnumerable<CommentFor> NullifyCFor()
        {
            return (IEnumerable<CommentFor>)Manager.Remove.Rem(_query.NullifyCFor());
        }
    }
}