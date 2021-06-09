using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.MainPage
{
    public class GetGroupsByLectorA : ADTOAnswer
    {
        public string NameG { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string NameC { get; set; }

        public GetGroupsByLectorA()
        {
        }

        public GetGroupsByLectorA(int id, string nameG, string startDate, string endDate, string nameC)
        {
            Id = id;
            NameG = nameG;
            StartDate = startDate;
            EndDate = endDate;
            NameC = nameC;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetGroupsByLectorA)obj);
        }

        private bool Equals(GetGroupsByLectorA other)
        {
            return Id == other.Id
                   && NameG == other.NameG
                   && StartDate == other.StartDate
                   && EndDate == other.EndDate
                   && NameC == other.NameC;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, NameG, StartDate, EndDate, NameC);
        }
    }
}