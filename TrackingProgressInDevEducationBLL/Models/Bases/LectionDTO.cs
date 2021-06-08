using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class LectionDTO : ADTOAnswer
    {
        public int GroupId { get; set; }
        public int LectorId { get; set; }
        public string StartedOn { get; set; }

        public LectionDTO()
        {
        }

        public LectionDTO(Lection lection)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Lection, LectionDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            LectionDTO tmpLectionDTO = mapper.Map<LectionDTO>(lection);

            this.GroupId = tmpLectionDTO.GroupId;
            this.LectorId = tmpLectionDTO.LectorId;
            this.StartedOn = tmpLectionDTO.StartedOn;
        }

        public override bool Equals(object obj)
        {
            return Equals((LectionDTO)obj);
        }

        private bool Equals(LectionDTO other)
        {
            return GroupId == other.GroupId
                   && LectorId == other.LectorId
                   && StartedOn == other.StartedOn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GroupId, LectorId, StartedOn);
        }
    }
}
