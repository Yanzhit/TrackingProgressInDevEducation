using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BLectorGroup : AbstractBModel
    {
        public int LectorId { get; set; }
        public int GroupId { get; set; }

        public BLectorGroup()
        {
        }

        public BLectorGroup(LectorGroup lectorGroup)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorGroup, BLectorGroup>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BLectorGroup tmpBLectorGroup = mapper.Map<BLectorGroup>(lectorGroup);

            this.LectorId = tmpBLectorGroup.LectorId;
            this.GroupId = tmpBLectorGroup.GroupId;
        }

        public override bool Equals(object obj)
        {
            return Equals((BLectorGroup)obj);
        }

        private bool Equals(BLectorGroup other)
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