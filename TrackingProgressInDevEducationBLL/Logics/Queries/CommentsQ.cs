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

        public AbstractModel GetCommentsByStudent(GetCommentsByStudentQ model)
        {
            WriteTypes(new Comments().GetCommentsByStudent());
            return GetModelBaseSingle(model);
        }

        public AbstractModel SetCommentToTeam(SetCommentsToTeamQ model)
        {
            WriteTypes(new Comments().SetCommentToTeam());
            return GetModelBaseSingle(model);
        }

    }
}
