using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Lection : AbstractModel
    {
        public int GroupId  { get; set; }
        public int LectorId  { get; set; }
        public string StartedOn  { get; set; }

        public Lection()
        {
        }

        public Lection(Lection lection) : base(lection)
        {
            GroupId = lection.GroupId;
            LectorId = lection.LectorId;
            StartedOn = lection.StartedOn;
        }
        public Lection(object obj) : base(obj)
        {
            var lection = (Lection) obj;
            GroupId = lection.GroupId;
            LectorId = lection.LectorId;
            StartedOn = lection.StartedOn;
        }

        public override bool Equals(object obj)
        {
            return Equals((Lection)obj);
        }

        private bool Equals(Lection other)
        {
            return Id == other.Id
                   && GroupId == other.GroupId
                   && LectorId == other.LectorId
                   && StartedOn == other.StartedOn;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(GroupId);
            hashCode.Add(LectorId);
            hashCode.Add(StartedOn);
            return hashCode.ToHashCode();
        }
    }
}