using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class HomeworkGroup : AbstrackModels
    {
        public int HomeworkId { get; set; }
        public int GroupId { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((HomeworkGroup)obj);
        }

        private bool Equals(HomeworkGroup other)
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
