using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class HWGroup : AbstractModel
    {
        public int HomeworkId { get; set; }
        public int GroupId { get; set; }

        public HWGroup()
        {
        }

        public HWGroup(int homeworkId, int groupId)
        {
            HomeworkId = homeworkId;
            GroupId = groupId;
        }

        public override bool Equals(object obj)
        {
            return Equals((HWGroup)obj);
        }

        private bool Equals(HWGroup other)
        {
            return HomeworkId == other.HomeworkId
                   && GroupId == other.GroupId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(HomeworkId, GroupId);
        }
    }
}
