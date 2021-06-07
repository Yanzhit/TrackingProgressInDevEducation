using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class TestComplete : AbstractModel
    {
        public int TestId { get; set; }
        public int StudentId { get; set; }
        public bool Status { get; set; }
        public string ApproveDate { get; set; }
        public int? Score { get; set; }

        public TestComplete()
        {
        }

        public TestComplete(int testId, int studentId, bool status, string approveDate, int? score)
        {
            TestId = testId;
            StudentId = studentId;
            Status = status;
            ApproveDate = approveDate;
            Score = score;
        }

        public override bool Equals(object obj)
        {
            return Equals((TestComplete)obj);
        }

        private bool Equals(TestComplete other)
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
