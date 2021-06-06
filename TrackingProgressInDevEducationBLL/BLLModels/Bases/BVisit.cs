using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BVisit : AbstractBModel
    {
        public bool VisitStatus { get; set; }
        public int StudentId { get; set; }
        public int LectionId { get; set; }

        public BVisit()
        {
        }

        public BVisit(Visit visit)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Visit, BVisit>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BVisit tBVisit = mapper.Map<BVisit>(visit);

            this.VisitStatus = tBVisit.VisitStatus;
            this.StudentId = tBVisit.StudentId;
            this.LectionId = tBVisit.LectionId;
        }

        public override bool Equals(object obj)
        {
            return Equals((BVisit)obj);
        }

        private bool Equals(BVisit other)
        {
            return VisitStatus == other.VisitStatus
                   && StudentId == other.StudentId
                   && LectionId == other.LectionId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(VisitStatus, StudentId, LectionId);
        }
    }
}
