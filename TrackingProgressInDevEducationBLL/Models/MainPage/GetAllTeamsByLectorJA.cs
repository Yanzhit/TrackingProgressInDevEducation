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

        public GetAllTeamsByLectorJA(int id, string name, string from, string to, int studCount)
        {
            Id = id;
            Name = name;
            From = from;
            To = to;
            StudentCount = studCount;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetAllTeamsByLectorJA)obj);
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
