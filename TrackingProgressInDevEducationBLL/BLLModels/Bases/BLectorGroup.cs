using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BLectorGroup
    {
        public int LectorId { get; set; }
        public int GroupId { get; set; }

        public BLectorGroup()
        {
        }

        public BLectorGroup(LectorGroup lectorGroup)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorGroup, BLectorGroup>());
            Mapper mapper = new Mapper(config);
            BLectorGroup tmpBHomework = mapper.Map<BLectorGroup>(lectorGroup);

            this.LectorId = tmpBHomework.LectorId;
            this.GroupId = tmpBHomework.GroupId;
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