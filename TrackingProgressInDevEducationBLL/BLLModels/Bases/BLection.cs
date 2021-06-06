using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BLection : AbstractBModel
    {
        public int GroupId { get; set; }
        public int LectorId { get; set; }
        public DateTime StartedOn { get; set; }

        public BLection()
        {
        }

        public BLection(Lection lection)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Lection, BLection>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BLection tmpBLection = mapper.Map<BLection>(lection);

            this.GroupId = tmpBLection.GroupId;
            this.LectorId = tmpBLection.LectorId;
            this.StartedOn = tmpBLection.StartedOn;
        }

        public override bool Equals(object obj)
        {
            return Equals((BLection)obj);
        }

        private bool Equals(BLection other)
        {
            return GroupId == other.GroupId
                   && LectorId == other.LectorId
                   && StartedOn == other.StartedOn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GroupId, LectorId, StartedOn);
        }
    }
}
