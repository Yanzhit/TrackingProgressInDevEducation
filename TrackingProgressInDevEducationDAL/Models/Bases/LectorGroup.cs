using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class LectorGroup : AbstractModel
    {
        public int LectorId { get; }
        public int GroupId { get; }

        public LectorGroup()
        {
        }

        public LectorGroup(LectorGroup lectorGroup) : base(lectorGroup)
        {
            LectorId = lectorGroup.LectorId;
            GroupId = lectorGroup.GroupId;
        }
        public LectorGroup(object obj) : base(obj)
        {
            var lectorGroup = (LectorGroup) obj;
            LectorId = lectorGroup.LectorId;
            GroupId = lectorGroup.GroupId;
        }
        public override bool Equals(object obj)
        {
            return Equals((LectorGroup)obj);
        }

        private bool Equals(LectorGroup other)
        {
            return Id == other.Id
                   && LectorId == other.LectorId
                   && GroupId == other.GroupId;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            return hashCode.ToHashCode();
        }
    }
}