using TrackingProgressInDevEducationBLL.Models.Comment;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class CommentsQ : AQuery
    {
        public AbstractModel SetNewComment(SetCommentsQ setCommentsQ)
        {
            WriteTypes(new Comments().SetNewComment());
            return GetModelBaseSingle(setCommentsQ);
        }
    }
}
