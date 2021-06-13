using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.MainPage
{
    public class GetAllTeamsByLectorJA : ADTOAnswer
    {
        public string Name { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int StudentCount { get; set; }

        public GetAllTeamsByLectorJA()
        {
        }

        public GetAllTeamsByLectorJA(GetAllTeamsByLectorJA model)
        {
            Id = model.Id;
            Name = model.Name;
            From = model.From;
            To = model.To;
            StudentCount = model.StudentCount;
        }

        public override bool Equals(object obj)
        {
            if (obj is GetAllTeamsByLectorJA)
            {
                return Equals((GetAllTeamsByLectorJA)obj);
            }
            else
            {
                return true;
            }
        }

        private bool Equals(GetAllTeamsByLectorJA other)
        {
            return Id == other.Id
                   && Name == other.Name
                   && From == other.From
                   && To == other.To
                   && StudentCount == other.StudentCount;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, From, To, StudentCount);
        }
    }
}
