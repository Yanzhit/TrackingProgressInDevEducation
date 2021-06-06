using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class HWCompleteDTO : ADTOAnswer
    {
        public int HomeworkId { get; set; }
        public int StudentId { get; set; }
        public bool Status { get; set; }
        public DateTime? ApproveDate { get; set; }
        public int? Score { get; set; }
        public DateTime? CreatedOn { get; set; }

        public HWCompleteDTO()
        {
        }

        public HWCompleteDTO(HWComplete hwComplete)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HWComplete, HWCompleteDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            HWCompleteDTO tmpHwbCompleteDTO = mapper.Map<HWCompleteDTO>(hwComplete);

            this.HomeworkId = tmpHwbCompleteDTO.HomeworkId;
            this.StudentId = tmpHwbCompleteDTO.StudentId;
            this.Status = tmpHwbCompleteDTO.Status;
            this.ApproveDate = tmpHwbCompleteDTO.ApproveDate;
            this.Score = tmpHwbCompleteDTO.Score;
            this.CreatedOn = tmpHwbCompleteDTO.CreatedOn;
        }

        public override bool Equals(object obj)
        {
            return Equals((HWCompleteDTO)obj);
        }

        private bool Equals(HWCompleteDTO other)
        {
            return HomeworkId == other.HomeworkId
                   && StudentId == other.StudentId
                   && Status == other.Status
                   && ApproveDate == other.ApproveDate
                   && Score == other.Score
                   && CreatedOn == other.CreatedOn;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(HomeworkId, StudentId, Status, ApproveDate, Score, CreatedOn);
        }
    }
}
