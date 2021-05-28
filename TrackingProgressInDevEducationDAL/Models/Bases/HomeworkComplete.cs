using System;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class HomeworkComplete : IModels
    {
        public int HomeworkId { get; set; }
        public int StudentId { get; set; }
        public int Status { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((HomeworkComplete)obj);
        }

        private bool Equals(HomeworkComplete other)
        {
            return HomeworkId == other.HomeworkId &&
                   StudentId == other.StudentId &&
                   Status == other.Status;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(HomeworkId, StudentId, Status);
        }
    }
}