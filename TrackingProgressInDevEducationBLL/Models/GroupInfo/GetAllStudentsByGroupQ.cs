using System;

namespace TrackingProgressInDevEducationBLL.Models.GroupInfo
{
    public class GetAllStudentsByGroupQ : ADTOQuery
    {
        public int Id { get; set; }
        public GetAllStudentsByGroupQ()
        {
        }

        public GetAllStudentsByGroupQ(int id)
        {
            Id = id;
        }
        public override bool Equals(object obj)
        {
            return Equals((GetAllStudentsByGroupQ)obj);
        }

        private bool Equals(GetAllStudentsByGroupQ other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
