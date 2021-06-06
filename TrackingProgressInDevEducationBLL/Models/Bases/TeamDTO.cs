using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class TeamDTO : ADTOAnswer
    {
        public string Name { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }

        public TeamDTO()
        {
        }

        public TeamDTO(Team team)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Team, TeamDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            TeamDTO tmpTeamDTO = mapper.Map<TeamDTO>(team);

            this.Name = tmpTeamDTO.Name;
            this.From = tmpTeamDTO.From;
            this.To = tmpTeamDTO.To;
        }

        public override bool Equals(object obj)
        {
            return Equals((TeamDTO)obj);
        }

        private bool Equals(TeamDTO other)
        {
            return Name == other.Name
                   && From == other.From
                   && To == other.To;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, From, To);
        }
    }
}
