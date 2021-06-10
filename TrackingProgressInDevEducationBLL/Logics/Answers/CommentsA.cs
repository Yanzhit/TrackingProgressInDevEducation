using TrackingProgressInDevEducationBLL.Models.Comment;
using TrackingProgressInDevEducationBLL.Transfers;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class CommentsA : AAnswer
    {
        public SetCommentsA SetNewComment(TrackingProgressInDevEducationDAL.Models.Bases.Comment model)
        {
            WriteTypes(new Comments().SetNewComment());
            return (SetCommentsA)GetModelBaseSingle(model);
        }
    }
}
