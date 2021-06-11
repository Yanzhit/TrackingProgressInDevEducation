using System;

namespace TrackingProgressInDevEducationBLL.Models.Comment
{
    public class SetCommentsQ : ADTOQuery
    {
        public string Text { get; set; }
        public int TypeId { get; set; }
        public int? StudentId { get; set; }
        public int CreatedBy { get; set; }
        public int? Estimation { get; set; }

        public SetCommentsQ()
        {
        }

        public SetCommentsQ(string text, int typeId, int studentId, int createdBy, int estimation)
        {
            Text = text;
            TypeId = typeId;
            StudentId = studentId;
            CreatedBy = createdBy;
            Estimation = estimation;
        }

        public override bool Equals(object obj)
        {
            return Equals((SetCommentsQ)obj);
        }

        private bool Equals(SetCommentsQ other)
        {
            return Text == other.Text
                   && TypeId == other.TypeId
                   && StudentId == other.StudentId
                   && CreatedBy == other.CreatedBy
                   && Estimation == other.Estimation;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, TypeId, StudentId, CreatedBy, Estimation);
        }

    }
}
