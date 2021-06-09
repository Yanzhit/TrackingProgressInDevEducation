using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Visit : AbstractModel
    {
        public bool VisitStatus { get; }
        public int StudentId { get; }
        public int LectionId { get; }

        public Visit()
        {
        }

        public Visit(Visit visit) : base(visit)
        {
            VisitStatus = visit.VisitStatus;
            StudentId = visit.StudentId;
            LectionId = visit.LectionId;
        }

        public override bool Equals(object obj)
        {
            return Equals((Visit)obj);
        }

        private bool Equals(Visit other)
        {
            return Id == other.Id
                   && VisitStatus == other.VisitStatus
                   && StudentId == other.StudentId
                   && LectionId == other.LectionId;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(VisitStatus);
            hashCode.Add(StudentId);
            hashCode.Add(LectionId);
            return hashCode.ToHashCode();
        }
    }
}
