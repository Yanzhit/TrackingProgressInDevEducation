using System;

namespace TrackingProgressInDevEducationBLL.Models.SignIn
{
    /// <summary>
    /// Получение лектора.
    /// </summary>
    public class LectorAnswer : ADTOAnswer
    {
        public bool IsActivated { get; set; }
        

        public LectorAnswer()
        {
        }

        public LectorAnswer(int id, bool isActivated)
        {
            Id = id;
            IsActivated = isActivated;
        }

        public override bool Equals(object obj)
        {
            return Equals((LectorAnswer)obj);
        }

        private bool Equals(LectorAnswer other)
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