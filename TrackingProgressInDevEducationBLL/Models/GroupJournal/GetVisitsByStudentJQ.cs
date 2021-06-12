using System;

namespace TrackingProgressInDevEducationBLL.Models.GroupJournal
{
    public class GetVisitsByStudentJQ : ADTOQuery
    {
        public int StudentId { get; set; }
        public GetVisitsByStudentJQ()
        {
        }

        public GetVisitsByStudentJQ(int studentId)
        {
            StudentId = studentId;
        }
        public override bool Equals(object obj)
        {
            return Equals((GetVisitsByStudentJQ)obj);
        }

        private bool Equals(GetVisitsByStudentJQ other)
        {
            return StudentId == other.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId);
        }
    }
}