using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        public int StudCount { get; set; }

        public GetGroupsByLectorA()
        {
        }

        public GetGroupsByLectorA(GetGroupsByLectorA model)
        {
            Id = model.Id;
            NameG = model.NameG;
            StartDate = model.StartDate;
            EndDate = model.EndDate;
            NameC = model.NameC;
            StudCount = model.StudCount;
        }

        public override bool Equals(object obj)
        {
            return obj is not GetGroupsByLectorA a || Equals(a);
        }

        private bool Equals(GetGroupsByLectorA other)
        {
            return Id == other.Id
                   && NameG == other.NameG
                   && StartDate == other.StartDate
                   && EndDate == other.EndDate
                   && NameC == other.NameC
                   && StudCount == other.StudCount;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, NameG, StartDate, EndDate, NameC, StudCount);
        }
    }
}