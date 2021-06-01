using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class LectorGroup : AbstractModel
    {
        public int LectorId { get; set; }
        public int GroupId { get; set; }

        public LectorGroup()
        {
        }

        public LectorGroup(int lectorId, int groupId)
        {
            LectorId = lectorId;
            GroupId = groupId;
        }

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