using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BHWComplete
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
            Mapper mapper = new Mapper(config);
            BHWComplete tmpBHomework = mapper.Map<BHWComplete>(hwComplete);

            this.HomeworkId = tmpBHomework.HomeworkId;
            this.StudentId = tmpBHomework.StudentId;
            this.Status = tmpBHomework.Status;
            this.ApproveDate = tmpBHomework.ApproveDate;
            this.Score = tmpBHomework.Score;
            this.CreatedOn = tmpBHomework.CreatedOn;
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
