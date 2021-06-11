using System;

namespace TrackingProgressInDevEducationDAL.Models.Others
{
    public class GetGroupByIdJ : AbstractModel
    {
        public string NameG { get; set; }
        public string NameC { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }

        public GetGroupByIdJ()
        {
        }
        public GetGroupByIdJ(GetGroupByIdJ groupJ) : base(groupJ)
        {
            NameG = groupJ.NameG;
            NameC = groupJ.NameC;
            StartDate = groupJ.StartDate;
            EndDate = groupJ.EndDate;
            Description = groupJ.Description;
        }
        public GetGroupByIdJ(object obj) : base(obj)
        {
            var groupJ = (GetGroupByIdJ)obj;
            NameG = groupJ.NameG;
            NameC = groupJ.NameC;
            StartDate = groupJ.StartDate;
            EndDate = groupJ.EndDate;
            Description = groupJ.Description;
        }
        public override bool Equals(object obj)
        {
            return Equals((GetGroupByIdJ)obj);
        }

        private bool Equals(GetGroupByIdJ other)
        {
            return Id == other.Id
                && NameG == other.NameG
                && NameC == other.NameC
                && StartDate == other.StartDate
                && EndDate == other.EndDate
                && Description == other.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
