using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BLection
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
            Mapper mapper = new Mapper(config);
            BLection tmpBHomework = mapper.Map<BLection>(lection);

            this.GroupId = tmpBHomework.GroupId;
            this.LectorId = tmpBHomework.LectorId;
            this.StartedOn = tmpBHomework.StartedOn;
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
