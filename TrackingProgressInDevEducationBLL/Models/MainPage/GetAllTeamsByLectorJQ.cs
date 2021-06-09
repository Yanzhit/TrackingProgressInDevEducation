using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.MainPage
{
    class GetAllTeamsByLectorJQ : ADTOQuery
    {
        public string Name { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public GetAllTeamsByLectorJQ()
        {
        }

        public GetAllTeamsByLectorJQ(string name, string from, string to)
        {
            Name = name;
            From = from;
            To = to;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetAllTeamsByLectorJQ)obj);
        }

        private bool Equals(GetAllTeamsByLectorJQ other)
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
