using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Comments : AbstractModels
    {
        public string Text { get; set; }
        public int TypeId { get; set; }
        public int StudentId { get; set; }
        public int CreatedBy { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((Comments)obj);
        }

        private bool Equals(Comments other)
        {
            return Text == other.Text
                   && TypeId == other.TypeId
                   && StudentId == other.StudentId
                   && CreatedBy == other.CreatedBy;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, TypeId, StudentId, CreatedBy);
        }
    }
}