using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class CommentsFor : AFacade
    {
        private readonly QCommentFor _query = new();
    
        public AResult SetNewCType()
        {
            return (AResult)Manager.Setter.Single(_query.SetNewCType());
        }

        public IEnumerable<AResult> NullifyCTypes()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyCTypes());
        }
    }
}