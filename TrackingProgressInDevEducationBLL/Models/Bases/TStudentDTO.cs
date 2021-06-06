using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class TStudentDTO : ADTOAnswer
    {
        public int TeamId { get; set; }
        public int StudentId { get; set; }

        public TStudentDTO()
        {
        }

        public TStudentDTO(TStudent tStudent)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TStudent, TStudentDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            TStudentDTO tBStudentDTO = mapper.Map<TStudentDTO>(tStudent);

            this.TeamId = tBStudentDTO.TeamId;
            this.StudentId = tBStudentDTO.StudentId;
        }

        public override bool Equals(object obj)
        {
            return Equals((TStudentDTO)obj);
        }

        private bool Equals(TStudentDTO other)
        {
            return TeamId == other.TeamId
                   && StudentId == other.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TeamId, StudentId);
        }
    }
}