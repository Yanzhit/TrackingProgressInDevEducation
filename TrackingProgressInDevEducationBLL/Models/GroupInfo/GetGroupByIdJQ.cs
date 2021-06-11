using System;

namespace TrackingProgressInDevEducationBLL.Models.GroupInfo
{
    public class GetGroupByIdJQ : ADTOQuery
    {
        public int Id { get; set; }
        public GetGroupByIdJQ()
        {
        }

        public GetGroupByIdJQ(int id)
        {
            Id = id;
        }
        public override bool Equals(object obj)
        {
            return Equals((GetGroupByIdJQ)obj);
        }

        private bool Equals(GetGroupByIdJQ other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
