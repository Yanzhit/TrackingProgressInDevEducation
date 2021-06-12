using System;

namespace TrackingProgressInDevEducationDAL.Models.Others
{
    public class GetVisitsByStudentJ : AbstractModel
    {
        public bool VisitStatus { get; set; }
        public string StartedOn { get; set; }
        public int StudentId { get; set; }

        public GetVisitsByStudentJ()
        {
        }

        public GetVisitsByStudentJ(GetVisitsByStudentJ model) : base(model)
        {
            VisitStatus = model.VisitStatus;
            StartedOn = model.StartedOn;
            StudentId = model.StudentId;
        }
        public GetVisitsByStudentJ(object obj) : base(obj)
        {
            var model = (GetVisitsByStudentJ)obj;
            VisitStatus = model.VisitStatus;
            StartedOn = model.StartedOn;
            StudentId = model.StudentId;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetVisitsByStudentJ)obj);
        }

        private bool Equals(GetVisitsByStudentJ other)
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