using System;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class LectorGroup : AbstrackModels
    {
        public int LectorId { get; set; }
        public int GroupId { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((LectorGroup)obj);
        }

        private bool Equals(LectorGroup other)
        {
            return LectorId == other.LectorId
                   && GroupId == other.GroupId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(LectorId, GroupId);
        }
    }
}