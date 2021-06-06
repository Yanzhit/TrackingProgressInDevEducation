using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BCourse : AbstractBModel
    {
        public string Name { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime FinishedOn { get; set; }

        public BCourse()
        {
        }

        public BCourse(Course course)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Course, BCourse>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BCourse tmpBCourse = mapper.Map<BCourse>(course);

            this.Name = tmpBCourse.Name;
            this.StartedOn = tmpBCourse.StartedOn;
            this.FinishedOn = tmpBCourse.StartedOn;
        }

        public override bool Equals(object obj)
        {
            return Equals((BCourse)obj);
        }

        private bool Equals(BCourse other)
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
