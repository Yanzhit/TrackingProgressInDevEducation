using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.Comment
{
    public class GetCommentsByStudentQ : ADTOQuery
    {
        public int StudentId { get; set; }
        public int CommentType { get; set; }
        public int CommentFor { get; set; }

        public GetCommentsByStudentQ()
        {
        }

        public GetCommentsByStudentQ(int studentId, int commentType, int commentFor)
        {
            StudentId = studentId;
            CommentType = commentType;
            CommentFor = commentFor;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetCommentsByStudentQ)obj);
        }

        private bool Equals(GetCommentsByStudentQ other)
        {
            return StudentId == other.StudentId
                && CommentType == other.CommentType
                && CommentFor == other.CommentFor;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId, CommentType, CommentFor);
        }
    }
}
