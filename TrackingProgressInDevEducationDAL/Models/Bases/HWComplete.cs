using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class HWComplete : AbstractModel
    {
        public int HomeworkId { get; set; }
        public int StudentId { get; set; }
        public int Status { get; set; }

        public HWComplete(int homeworkId, int studentId, int status)
        {
            HomeworkId = homeworkId;
            StudentId = studentId;
            Status = status;
        }

        public override bool Equals(object obj)
        {
            return Equals((HWComplete)obj);
        }

        private bool Equals(HWComplete other)
        {
            return HomeworkId == other.HomeworkId
                   && StudentId == other.StudentId
                   && Status == other.Status;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(HomeworkId, StudentId, Status);
        }
    }
}