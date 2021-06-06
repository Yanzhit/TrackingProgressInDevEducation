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
    public class BHWGroup : AbstractBModel
    {
        public int HomeworkId { get; set; }
        public int GroupId { get; set; }

        public BHWGroup()
        {
        }

        public BHWGroup(HWGroup hwGroup)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HWGroup, BHWGroup>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BHWGroup tmpBHWGroup = mapper.Map<BHWGroup>(hwGroup);

            this.HomeworkId = tmpBHWGroup.HomeworkId;
            this.GroupId = tmpBHWGroup.GroupId;
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
