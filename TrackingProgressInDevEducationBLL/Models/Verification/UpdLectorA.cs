using System;

namespace TrackingProgressInDevEducationBLL.Models.Verification
{
    public class UpdLectorA : ADTOAnswer
    {
        public bool IsActivated { get; set; }


        public UpdLectorA()
        {
        }

        public UpdLectorA(int id, bool isActivated)
        {
            Id = id;
            IsActivated = isActivated;
        }
        public override bool Equals(object obj)
        {
            return Equals((UpdLectorA)obj);
        }

        private bool Equals(UpdLectorA other)
        {
            return Id == other.Id
                   && IsActivated == other.IsActivated;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, IsActivated);
        }
    }
}