using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class HWGroup : AbstractModel
    {
        public int HomeworkId  { get; set; }
        public int GroupId  { get; set; }

        public HWGroup()
        {
        }

        public HWGroup(HWGroup hwGroup) : base(hwGroup)
        {
            HomeworkId = hwGroup.HomeworkId;
            GroupId = hwGroup.GroupId;
        }
        public HWGroup(object obj) : base(obj)
        {
            var hwGroup = (HWGroup) obj;
            HomeworkId = hwGroup.HomeworkId;
            GroupId = hwGroup.GroupId;
        }

        public override bool Equals(object obj)
        {
            return Equals((HWGroup)obj);
        }

        private bool Equals(HWGroup other)
        {
            return Id == other.Id
                   && HomeworkId == other.HomeworkId
                   && GroupId == other.GroupId;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(HomeworkId);
            hashCode.Add(GroupId);
            return hashCode.ToHashCode();
        }
    }
}
