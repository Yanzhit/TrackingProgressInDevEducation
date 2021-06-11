using TrackingProgressInDevEducationBLL.Models.Comment;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class Comments : ATransfer
    {
        public Comments SetNewCommentToStudent()
        {
            Query = typeof(SetCommentsQ);
            Base = typeof(Comment);
            Answer = typeof(SetCommentsA);
            return this;
        }
    }
}
