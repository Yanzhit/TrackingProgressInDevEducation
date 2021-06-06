using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BHWComplete : AbstractBModel
    {
        public int HomeworkId { get; set; }
        public int StudentId { get; set; }
        public bool Status { get; set; }
        public DateTime? ApproveDate { get; set; }
        public int? Score { get; set; }
        public DateTime? CreatedOn { get; set; }

        public BHWComplete()
        {
        }

        public BHWComplete(HWComplete hwComplete)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HWComplete, BHWComplete>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BHWComplete tmpHWBComplete = mapper.Map<BHWComplete>(hwComplete);

            this.HomeworkId = tmpHWBComplete.HomeworkId;
            this.StudentId = tmpHWBComplete.StudentId;
            this.Status = tmpHWBComplete.Status;
            this.ApproveDate = tmpHWBComplete.ApproveDate;
            this.Score = tmpHWBComplete.Score;
            this.CreatedOn = tmpHWBComplete.CreatedOn;
        }

        public override bool Equals(object obj)
        {
            return Equals((BHWComplete)obj);
        }

        private bool Equals(BHWComplete other)
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
