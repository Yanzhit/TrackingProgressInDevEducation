using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Comment : AbstractModel
    {
        public string Text { get; set; }
        public int TypeId { get; set; }
        public int StudentId { get; set; }
        public int CreatedBy { get; set; }
        public int TeamId { get; set; }

        public Comment()
        {
        }

        public Comment
            (
                string text,
                int typeId,
                int studentId,
                int createdBy,
                int teamId
            )
        {
            Text = text;
            TypeId = typeId;
            StudentId = studentId;
            CreatedBy = createdBy;
            TeamId = teamId;
        }
        public override bool Equals(object obj)
        {
            return Equals((Comment)obj);
        }

        private bool Equals(Comment other)
        {
            return Text == other.Text
                   && TypeId == other.TypeId
                   && StudentId == other.StudentId
                   && CreatedBy == other.CreatedBy
                   && TeamId == other.TeamId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, TypeId, StudentId, CreatedBy, TeamId);
        }
    }
}