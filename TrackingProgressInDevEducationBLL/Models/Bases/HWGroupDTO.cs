using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class HWGroupDTO : ADTOAnswer
    {
        public int HomeworkId { get; set; }
        public int GroupId { get; set; }

        public HWGroupDTO()
        {
        }

        public HWGroupDTO(HWGroup hwGroup)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HWGroup, HWGroupDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            HWGroupDTO tmpHwGroupDTO = mapper.Map<HWGroupDTO>(hwGroup);

            this.HomeworkId = tmpHwGroupDTO.HomeworkId;
            this.GroupId = tmpHwGroupDTO.GroupId;
        }

        public override bool Equals(object obj)
        {
            return Equals((HWGroupDTO)obj);
        }

        private bool Equals(HWGroupDTO other)
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
