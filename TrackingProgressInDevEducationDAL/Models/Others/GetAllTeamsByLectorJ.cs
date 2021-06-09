using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Models.Others
{
    public class GetAllTeamsByLectorJ : AbstractModel
    {
        public string Name { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int StudentCount { get; set; }

        public GetAllTeamsByLectorJ()
        {
        }

        public GetAllTeamsByLectorJ(GetAllTeamsByLectorJ lectorJ) : base(lectorJ)
        {
            Name = lectorJ.Name;
            From = lectorJ.From;
            To = lectorJ.To;
            StudentCount = lectorJ.StudentCount;
        }
        public GetAllTeamsByLectorJ(object obj) : base(obj)
        {
            var lectorJ = (GetAllTeamsByLectorJ)obj;
            Name = lectorJ.Name;
            From = lectorJ.From;
            To = lectorJ.To;
            StudentCount = lectorJ.StudentCount;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetAllTeamsByLectorJ)obj);
        }

        private bool Equals(GetAllTeamsByLectorJ other)
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
