using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BTStudent : AbstractBModel
    {
        public int TeamId { get; set; }
        public int StudentId { get; set; }

        public BTStudent()
        {
        }

        public BTStudent(TStudent tStudent)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TStudent, BTStudent>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BTStudent tBStudent = mapper.Map<BTStudent>(tStudent);

            this.TeamId = tBStudent.TeamId;
            this.StudentId = tBStudent.StudentId;
        }

        public override bool Equals(object obj)
        {
            return Equals((BTStudent)obj);
        }

        private bool Equals(BTStudent other)
        {
            return TeamId == other.TeamId
                   && StudentId == other.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TeamId, StudentId);
        }
    }
}