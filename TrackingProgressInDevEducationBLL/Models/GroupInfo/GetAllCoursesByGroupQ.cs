using System;

namespace TrackingProgressInDevEducationBLL.Models.GroupInfo
{
    public class GetAllCoursesByGroupQ : ADTOQuery
    {
        public int Id { get; set; }
        public GetAllCoursesByGroupQ()
        {
        }

        public GetAllCoursesByGroupQ(int id)
        {
            Id = id;
        }
        public override bool Equals(object obj)
        {
            return Equals((GetAllCoursesByGroupQ)obj);
        }

        private bool Equals(GetAllCoursesByGroupQ other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
