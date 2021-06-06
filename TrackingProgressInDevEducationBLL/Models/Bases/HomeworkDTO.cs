using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class HomeworkDTO : ADTOAnswer
    {
        public string Name { get; set; }
        public string Deskription { get; set; }

        public HomeworkDTO()
        {
        }

        public HomeworkDTO(Homework homework)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Homework, HomeworkDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            HomeworkDTO tmpHomeworkDTO = mapper.Map<HomeworkDTO>(homework);

            this.Name = tmpHomeworkDTO.Name;
            this.Deskription = tmpHomeworkDTO.Deskription;
        }

        public override bool Equals(object obj)
        {
            return Equals((HomeworkDTO)obj);
        }

        private bool Equals(HomeworkDTO other)
        {
            return Name == other.Name
                   && Deskription == other.Deskription;
        } 

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Deskription);
        }
    }
}
