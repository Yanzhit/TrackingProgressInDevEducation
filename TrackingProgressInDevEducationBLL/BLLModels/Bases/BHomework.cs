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
    public class BHomework : AbstractBModel
    {
        public string Name { get; set; }
        public string Deskription { get; set; }

        public BHomework()
        {
        }

        public BHomework(Homework homework)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Homework, BHomework>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BHomework tmpBHomework = mapper.Map<BHomework>(homework);

            this.Name = tmpBHomework.Name;
            this.Deskription = tmpBHomework.Deskription;
        }

        public override bool Equals(object obj)
        {
            return Equals((BHomework)obj);
        }

        private bool Equals(BHomework other)
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
