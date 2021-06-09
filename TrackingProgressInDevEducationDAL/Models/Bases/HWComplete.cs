using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class HWComplete : AbstractModel
    {
        public int HomeworkId { get; }
        public int StudentId { get; }
        public bool Status { get; }
        public string ApproveDate { get; }
        public int? Score { get; }
        public string CreatedOn { get; }

        public HWComplete()
        {
        }

        public HWComplete(HWComplete hwComplete) : base(hwComplete)
        {
            HomeworkId = hwComplete.HomeworkId;
            StudentId = hwComplete.StudentId;
            Status = hwComplete.Status;
            ApproveDate = hwComplete.ApproveDate;
            Score = hwComplete.Score;
            CreatedOn = hwComplete.CreatedOn;
        }

        public override bool Equals(object obj)
        {
            return Equals((HWComplete)obj);
        }

        private bool Equals(HWComplete other)
        {
            return Id == other.Id
                   && HomeworkId == other.HomeworkId
                   && StudentId == other.StudentId
                   && Status == other.Status
                   && ApproveDate == other.ApproveDate
                   && Score == other.Score
                   && CreatedOn == other.CreatedOn;
        }
        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(HomeworkId);
            hashCode.Add(StudentId);
            hashCode.Add(Status);
            hashCode.Add(ApproveDate);
            hashCode.Add(Score);
            hashCode.Add(CreatedOn);
            return hashCode.ToHashCode();
        }
    }
}