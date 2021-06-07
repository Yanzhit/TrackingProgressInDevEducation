using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class CommentsFor : AFacade
    {
        private readonly QCommentFor _query = new();
    
        public CommentFor SetNewCType()
        {
            return (CommentFor)Manager.Setter.Single(_query.SetNewCType());
        }

        public IEnumerable<CommentFor> NullifyCTypes()
        {
            return (IEnumerable<CommentFor>)Manager.Remove.Rem(_query.NullifyCTypes());
        }
    }
}