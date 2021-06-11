using System;

namespace TrackingProgressInDevEducationBLL.Models.GroupInfo
{
    public class GetGroupByIdJA : ADTOAnswer
    {
        public string NameG { get; set; }
        public string NameC { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }

        public GetGroupByIdJA()
        {
        }
        public GetGroupByIdJA(string nameG, string nameC, string startDate, string endDate, string description)
        {
            NameG = nameG;
            NameC = nameC;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
        }
        public override bool Equals(object obj)
        {
            return Equals((GetGroupByIdJA)obj);
        }

        private bool Equals(GetGroupByIdJA other)
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
