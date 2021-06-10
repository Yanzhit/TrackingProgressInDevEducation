using TrackingProgressInDevEducationBLL.Models.Comment;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class Comments : ATransfer
    {
        public Comments SetNewComment()
        {
            Query = typeof(SetCommentsQ);
            Base = typeof(Comment);
            Answer = typeof(SetCommentsA);
            return this;
        }
    }
}
