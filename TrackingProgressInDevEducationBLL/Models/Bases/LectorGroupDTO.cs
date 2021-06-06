using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class LectorGroupDTO : ADTOAnswer
    {
        public int LectorId { get; set; }
        public int GroupId { get; set; }

        public LectorGroupDTO()
        {
        }

        public LectorGroupDTO(LectorGroup lectorGroup)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorGroup, LectorGroupDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            LectorGroupDTO tmpLectorGroupDTO = mapper.Map<LectorGroupDTO>(lectorGroup);

            this.LectorId = tmpLectorGroupDTO.LectorId;
            this.GroupId = tmpLectorGroupDTO.GroupId;
        }

        public override bool Equals(object obj)
        {
            return Equals((LectorGroupDTO)obj);
        }

        private bool Equals(LectorGroupDTO other)
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