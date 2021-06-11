using TrackingProgressInDevEducationBLL.Models.Comment;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class CommentsA : AAnswer
    {
        public SetCommentsA SetNewCommentToStudent(Comment model)
        {
            WriteTypes(new Comments().SetNewCommentToStudent());
            return (SetCommentsA)GetModelBaseSingle(model);
        }
    }
}
