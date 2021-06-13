using System;

namespace TrackingProgressInDevEducationBLL.Models.Team
{
    public class SetTeamQ : ADTOQuery
    {
        public string Name { get; set; }
        public int? TeamId { get; set; }
        public int LectorId { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public SetTeamQ()
        {

        }

        public override bool Equals(object obj)
        {
            return Equals((SetTeamQ)obj);
        }

        private bool Equals(SetTeamQ other)
        {
            return Name == other.Name
                   && From == other.From
                   && To == other.To;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, From, To);
        }
    }
}
