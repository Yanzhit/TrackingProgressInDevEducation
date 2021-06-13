using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models.Comment;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class CommentsA : AAnswer
    {
        public SetCommentsA SetNewCommentToStudent(Comment model)
        {
            WriteTypes(new Comments().SetNewCommentToStudent());
            return (SetCommentsA)GetModelBaseSingle(model);
        }

        public IEnumerable<GetCommentsByStudentA> GetCommentsByStudent(IEnumerable<AbstractModel> model)
        {
            WriteTypes(new Comments().GetCommentsByStudent());
            return (IEnumerable<GetCommentsByStudentA>)GetModelBaseSeveral(model);
        }
    }
}