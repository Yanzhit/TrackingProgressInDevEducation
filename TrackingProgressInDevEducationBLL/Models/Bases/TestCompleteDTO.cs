using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class TestCompleteDTO : ADTOAnswer
    {
        public int TestId { get; set; }
        public int StudentId { get; set; }
        public bool Status { get; set; }
        public DateTime? ApproveDate { get; set; }
        public int? Score { get; set; }

        public TestCompleteDTO()
        {
        }

        public TestCompleteDTO(TestComplete testComplete)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TestComplete, TestCompleteDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            TestCompleteDTO tmpTestCompleteDTO = mapper.Map<TestCompleteDTO>(testComplete);

            this.TestId = tmpTestCompleteDTO.TestId;
            this.StudentId = tmpTestCompleteDTO.StudentId;
            this.Status = tmpTestCompleteDTO.Status;
            this.ApproveDate = tmpTestCompleteDTO.ApproveDate;
            this.Score = tmpTestCompleteDTO.Score;
        }

        public override bool Equals(object obj)
        {
            return Equals((TestCompleteDTO)obj);
        }

        private bool Equals(TestCompleteDTO other)
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
