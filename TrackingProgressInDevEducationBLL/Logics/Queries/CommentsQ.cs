using TrackingProgressInDevEducationBLL.Models.Comment;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class CommentsQ : AQuery
    {
        public AbstractModel SetNewCommentToStudent(SetCommentsQ model)
        {
            WriteTypes(new Comments().SetNewCommentToStudent());
            return GetModelBaseSingle(model);
        }
    }
}
