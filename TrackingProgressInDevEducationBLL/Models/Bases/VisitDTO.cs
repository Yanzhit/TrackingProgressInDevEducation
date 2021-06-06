using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class VisitDTO : ADTOAnswer
    {
        public bool VisitStatus { get; set; }
        public int StudentId { get; set; }
        public int LectionId { get; set; }

        public VisitDTO()
        {
        }

        public VisitDTO(Visit visit)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Visit, VisitDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            VisitDTO tVisitDTO = mapper.Map<VisitDTO>(visit);

            this.VisitStatus = tVisitDTO.VisitStatus;
            this.StudentId = tVisitDTO.StudentId;
            this.LectionId = tVisitDTO.LectionId;
        }

        public override bool Equals(object obj)
        {
            return Equals((VisitDTO)obj);
        }

        private bool Equals(VisitDTO other)
        {
            return VisitStatus == other.VisitStatus
                   && StudentId == other.StudentId
                   && LectionId == other.LectionId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(VisitStatus, StudentId, LectionId);
        }
    }
}
