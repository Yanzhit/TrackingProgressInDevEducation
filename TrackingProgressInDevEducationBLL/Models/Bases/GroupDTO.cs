using System;
using AutoMapper;
using Group = System.Text.RegularExpressions.Group;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class GroupDTO : ADTOAnswer
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public GroupDTO()
        {
        }

        public GroupDTO(Group group)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            GroupDTO tmpGroupDTO = mapper.Map<GroupDTO>(group);

            this.Name = tmpGroupDTO.Name;
            this.CourseId = tmpGroupDTO.CourseId;
            this.StartDate = tmpGroupDTO.StartDate;
            this.EndDate = tmpGroupDTO.EndDate;
        }

        public override bool Equals(object obj)
        {
            return Equals((GroupDTO)obj);
        }

        private bool Equals(GroupDTO other)
        {
            return Name == other.Name
                   && CourseId == other.CourseId
                   && StartDate == other.StartDate
                   && EndDate == other.EndDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, CourseId, StartDate, EndDate);
        }
    }
}
