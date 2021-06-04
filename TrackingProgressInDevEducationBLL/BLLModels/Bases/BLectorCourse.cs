using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BLectorCourse
    {
        public int LectorId { get; set; }
        public int CourseId { get; set; }

        public BLectorCourse()
        {
        }

        public BLectorCourse(LectorCourse lectorCourse)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorCourse, BLectorCourse>());
            Mapper mapper = new Mapper(config);
            BLectorCourse tmpBHomework = mapper.Map<BLectorCourse>(lectorCourse);

            this.LectorId = tmpBHomework.LectorId;
            this.CourseId = tmpBHomework.CourseId;
        }

        public override bool Equals(object obj)
        {
            return Equals((BLectorCourse)obj);
        }

        private bool Equals(BLectorCourse other)
        {
            return LectorId == other.LectorId
                   && CourseId == other.CourseId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(LectorId, CourseId);
        }
    }
}