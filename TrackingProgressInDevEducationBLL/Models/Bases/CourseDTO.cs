using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class CourseDTO : ADTOAnswer
    {
        public string Name { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime FinishedOn { get; set; }

        public CourseDTO()
        {
        }

        public CourseDTO(Course course)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Course, CourseDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            CourseDTO tmpCourseDTO = mapper.Map<CourseDTO>(course);

            this.Name = tmpCourseDTO.Name;
            this.StartedOn = tmpCourseDTO.StartedOn;
            this.FinishedOn = tmpCourseDTO.StartedOn;
        }

        public override bool Equals(object obj)
        {
            return Equals((CourseDTO)obj);
        }

        private bool Equals(CourseDTO other)
        {
            return Name == other.Name
                   && StartedOn == other.StartedOn
                   && FinishedOn == other.FinishedOn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StartedOn, FinishedOn);
        }
    }
}
