using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class LectorCourseDTO : ADTOAnswer
    {
        public int LectorId { get; set; }
        public int CourseId { get; set; }

        public LectorCourseDTO()
        {
        }

        public LectorCourseDTO(LectorCourse lectorCourse)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorCourse, LectorCourseDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            LectorCourseDTO tmpLectorCourseDTO = mapper.Map<LectorCourseDTO>(lectorCourse);

            this.LectorId = tmpLectorCourseDTO.LectorId;
            this.CourseId = tmpLectorCourseDTO.CourseId;
        }

        public override bool Equals(object obj)
        {
            return Equals((LectorCourseDTO)obj);
        }

        private bool Equals(LectorCourseDTO other)
        {
            return LectorId == other.LectorId
                   && CourseId == other.CourseId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(LectorId, CourseId);
        }
    }
}