using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.MainPage
{
    class GetAllTeamsByLectorJA : ADTOAnswer
    {
        public string Name { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public GetAllTeamsByLectorJA()
        {
        }

        public GetAllTeamsByLectorJA(int id, string name, string from, string to)
        {
            Id = id;
            Name = name;
            From = from;
            To = to;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetAllTeamsByLectorJA)obj);
        }

        private bool Equals(GetAllTeamsByLectorJA other)
        {
            return Id == other.Id
                   &&Name == other.Name
                   && From == other.From
                   && To == other.To;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, From, To);
        }
    }
}
