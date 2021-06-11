using System;


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

        public GetGroupByLectorJ(GetGroupByLectorJ lectorJ) : base(lectorJ)
        {
            NameG = lectorJ.NameG;
            StartDate = lectorJ.StartDate;
            EndDate = lectorJ.EndDate;
            NameG = lectorJ.NameG;
            StudCount = lectorJ.StudCount;
        }
        public GetGroupByLectorJ(object obj) : base(obj)
        {
            var lectorJ = (GetGroupByLectorJ) obj;
            NameG = lectorJ.NameG;
            StartDate = lectorJ.StartDate;
            EndDate = lectorJ.EndDate;
            NameG = lectorJ.NameG;
            StudCount = lectorJ.StudCount;
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
