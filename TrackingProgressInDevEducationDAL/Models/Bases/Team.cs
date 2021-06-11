using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Team : AbstractModel
    {
        public string Name  { get; set; }
        public string From  { get; set; }
        public string To  { get; set; }

        public Team()
        {
        }

        public Team(Team team) : base(team)
        {
            Name = team.Name;
            From = team.From;
            To = team.To;
        }
        public Team(object obj) : base(obj)
        {
            var team = (Team) obj;
            Name = team.Name;
            From = team.From;
            To = team.To;
        }

        public override bool Equals(object obj)
        {
            return Equals((Team)obj);
        }

        private bool Equals(Team other)
        {
            return Id == other.Id 
                   && Name == other.Name
                   && From == other.From
                   && To == other.To;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(Name);
            hashCode.Add(From);
            hashCode.Add(To);
            return hashCode.ToHashCode();
        }
    }
}
