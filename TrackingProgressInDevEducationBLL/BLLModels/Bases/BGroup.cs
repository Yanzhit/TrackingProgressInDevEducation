using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;
using Group = System.Text.RegularExpressions.Group;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BGroup : AbstractBModel
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public BGroup()
        {
        }

        public BGroup(Group group)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, BGroup>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BGroup tmpBGroup = mapper.Map<BGroup>(group);

            this.Name = tmpBGroup.Name;
            this.CourseId = tmpBGroup.CourseId;
            this.StartDate = tmpBGroup.StartDate;
            this.EndDate = tmpBGroup.EndDate;
        }

        public override bool Equals(object obj)
        {
            return Equals((BGroup)obj);
        }

        private bool Equals(BGroup other)
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
