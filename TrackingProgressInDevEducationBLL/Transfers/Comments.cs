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

        public Comments GetCommentsByStudent()
        {
            Query = typeof(GetCommentsByStudentQ);
            Base = typeof(Comment);
            Answer = typeof(GetCommentsByStudentA);
            return this;
        }

        public Comments SetCommentToTeam()
        {
            Query = typeof(SetCommentsToTeamQ);
            Base = typeof(Comment);
            Answer = typeof(SetCommentsToTeamA);
            return this;
        }
    }
}
