using System;
using System.Diagnostics.Contracts;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Comment : AbstractModel
    {
        public string Text { get; set; }
        public int TypeId { get; set; }
        public int? StudentId { get; set; }
        public int CreatedBy { get; set; }
        public int? TeamId { get; set; }
        public int? Estimation { get; set; }

        public Comment()
        {
        }

        public Comment(Comment comment) : base(comment)
        {
            Text = comment.Text;
            TypeId = comment.TypeId;
            StudentId = comment.StudentId;
            CreatedBy = comment.CreatedBy;
            TeamId = comment.TeamId;
            Estimation = comment.Estimation;
        }
        public Comment(object obj) : base(obj)
        {
            var comment = (Comment) obj;
            Text = comment.Text;
            TypeId = comment.TypeId;
            StudentId = comment.StudentId;
            CreatedBy = comment.CreatedBy;
            TeamId = comment.TeamId;
            Estimation = comment.Estimation;
        }
        public override bool Equals(object obj)
        {
            return Equals((Comment)obj);
        }

        private bool Equals(Comment other)
        {
            return Id == other.Id
                   && Text == other.Text
                   && TypeId == other.TypeId
                   && StudentId == other.StudentId
                   && CreatedBy == other.CreatedBy
                   && TeamId == other.TeamId
                   && Estimation == other.Estimation;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(Text);
            hashCode.Add(TypeId);
            hashCode.Add(StudentId);
            hashCode.Add(CreatedBy);
            hashCode.Add(TeamId);
            hashCode.Add(Estimation);
            return hashCode.ToHashCode();
        }
    }
}