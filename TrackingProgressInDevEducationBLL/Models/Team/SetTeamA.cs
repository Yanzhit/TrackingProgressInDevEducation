using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.Team
{
    public class SetTeamA : ADTOAnswer
    {
        public int? TeamId { get; set; }
        public int? LectorId { get; set; }
        public string Name { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public SetTeamA()
        {
        }

        public SetTeamA(string name, string from, string to)
        {
            Name = name;
            From = from;
            To = to;
        }

        public override bool Equals(object obj)
        {
            return Equals((SetTeamA)obj);
        }

        private bool Equals(SetTeamA other)
        {
            return Id == other.Id
                   && Name == other.Name
                   && From == other.From
                   && To == other.To;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
