using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BHWGroup
    {
        public int HomeworkId { get; set; }
        public int GroupId { get; set; }

        public BHWGroup()
        {
        }

        public BHWGroup(HWGroup hwGroup)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HWGroup, BHWGroup>());
            Mapper mapper = new Mapper(config);
            BHWGroup tmpBHomework = mapper.Map<BHWGroup>(hwGroup);

            this.HomeworkId = tmpBHomework.HomeworkId;
            this.GroupId = tmpBHomework.GroupId;
        }

        public override bool Equals(object obj)
        {
            return Equals((BHWGroup)obj);
        }

        private bool Equals(BHWGroup other)
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
