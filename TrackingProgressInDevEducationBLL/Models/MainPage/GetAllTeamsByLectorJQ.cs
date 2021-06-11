using System;

namespace TrackingProgressInDevEducationBLL.Models.MainPage
{
    public class GetAllTeamsByLectorJQ : ADTOQuery
    {
        public int Id { get; set; }

        public GetAllTeamsByLectorJQ()
        {
        }

        public GetAllTeamsByLectorJQ(int id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetAllTeamsByLectorJQ)obj);
        }

        private bool Equals(GetAllTeamsByLectorJQ other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
