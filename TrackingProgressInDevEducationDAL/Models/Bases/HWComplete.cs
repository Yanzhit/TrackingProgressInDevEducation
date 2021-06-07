using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class HWComplete : AbstractModel
    {
        public int HomeworkId { get; set; }
        public int StudentId { get; set; }
        public bool Status { get; set; }
        public string ApproveDate { get; set; }
        public int? Score { get; set; }
        public string CreatedOn { get; set; }

        public HWComplete()
        {
        }

        public HWComplete(int homeworkId, int studentId, bool status, string approveDate, int? score, string createdOn)
        {
            HomeworkId = homeworkId;
            StudentId = studentId;
            Status = status;
            ApproveDate = approveDate;
            Score = score;
            CreatedOn = createdOn;
        }

        public override bool Equals(object obj)
        {
            return Equals((HWComplete)obj);
        }

        private bool Equals(HWComplete other)
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