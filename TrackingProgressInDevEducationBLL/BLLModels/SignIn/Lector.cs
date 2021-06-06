using System;

namespace TrackingProgressInDevEducationBLL.BLLModels.SignIn
{
    /// <summary>
    /// Получение лектора.
    /// </summary>
    public class Lector : AbstractBModel
    {
        public bool IsActivated { get; set; }

        public Lector()
        {
        }

        public Lector(int id, bool isActivated)
        {
            Id = id;
            IsActivated = isActivated;
        }

        public override bool Equals(object obj)
        {
            return Equals((Lector)obj);
        }

        private bool Equals(Lector other)
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