using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Models.Others
{
    public class GetGroupByLectorJ : AbstractModel
    {
		public string NameG { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public string NameC { get; set; }
		public int StudCount { get; set; }

        public GetGroupByLectorJ()
        {
        }

        public GetGroupByLectorJ(int id, string nameG, string startDate, 
            string endDate, string nameC, int studCount)
        {
            Id = id;
            NameG = nameG;
            StartDate = startDate;
            EndDate = endDate;
            NameG = nameG;
            StudCount = studCount;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetGroupByLectorJ)obj);
        }

        private bool Equals(GetGroupByLectorJ other)
        {
            return Id == other.Id
            && NameG == other.NameG
            && StartDate == other.StartDate
            && EndDate == other.EndDate
            && NameG == other.NameG
            && StudCount == other.StudCount;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, NameG, StartDate, EndDate, NameC, StudCount);
        }
    }
}
