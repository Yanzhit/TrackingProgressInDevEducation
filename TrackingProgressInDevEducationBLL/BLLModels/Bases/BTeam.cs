using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BTeam : AbstractBModel
    {
        public string Name { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }

        public BTeam()
        {
        }

        public BTeam(Team team)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Team, BTeam>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BTeam tmpBTeam = mapper.Map<BTeam>(team);

            this.Name = tmpBTeam.Name;
            this.From = tmpBTeam.From;
            this.To = tmpBTeam.To;
        }

        public override bool Equals(object obj)
        {
            return Equals((BTeam)obj);
        }

        private bool Equals(BTeam other)
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
