using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BTestComplete
    {
        public int TestId { get; set; }
        public int StudentId { get; set; }
        public bool Status { get; set; }
        public DateTime? ApproveDate { get; set; }
        public int? Score { get; set; }

        public BTestComplete()
        {
        }

        public BTestComplete(TestComplete testComplete)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TestComplete, BTestComplete>());
            Mapper mapper = new Mapper(config);
            BTestComplete tmpBTestComplete = mapper.Map<BTestComplete>(testComplete);

            this.TestId = tmpBTestComplete.TestId;
            this.StudentId = tmpBTestComplete.StudentId;
            this.Status = tmpBTestComplete.Status;
            this.ApproveDate = tmpBTestComplete.ApproveDate;
            this.Score = tmpBTestComplete.Score;
        }

        public override bool Equals(object obj)
        {
            return Equals((BTestComplete)obj);
        }

        private bool Equals(BTestComplete other)
        {
            return TestId == other.TestId
                   && StudentId == other.StudentId
                   && Status == other.Status
                   && ApproveDate == other.ApproveDate
                   && Score == other.Score;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TestId, StudentId, Status, ApproveDate, Score);
        }
    }
}
