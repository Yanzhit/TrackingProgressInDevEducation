using System;

namespace TrackingProgressInDevEducationBLL.Models.GroupJournal
{
    public class GetVisitsByStudentJA : ADTOAnswer
    {
        public bool VisitStatus { get; set; }
        public string StartedOn { get; set; }
        public int StudentId { get; set; }

        public GetVisitsByStudentJA()
        {
        }
        public GetVisitsByStudentJA(GetVisitsByStudentJA model)
        {
            VisitStatus = model.VisitStatus;
            StartedOn = model.StartedOn;
            StudentId = model.StudentId;
        }
        public override bool Equals(object obj)
        {
            return Equals((GetVisitsByStudentJA)obj);
        }

        private bool Equals(GetVisitsByStudentJA other)
        {
            return Id == other.Id
                   && VisitStatus == other.VisitStatus
                   && StartedOn == other.StartedOn
                   && StudentId == other.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, VisitStatus, StartedOn, StudentId);
        }
    }
}