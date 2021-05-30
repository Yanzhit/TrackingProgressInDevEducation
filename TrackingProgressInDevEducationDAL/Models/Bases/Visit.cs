using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Visit : AbstractModel
    {
        public bool VisitStatus { get; set; }
        public int StudentId { get; set; }
        public int LectionId { get; set; }

        protected Visit()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals((Visit)obj);
        }

        private bool Equals(Visit other)
        {
            return VisitStatus == other.VisitStatus
                   && StudentId == other.StudentId
                   && LectionId == other.LectionId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(VisitStatus, StudentId, LectionId);
        }
    }
}
