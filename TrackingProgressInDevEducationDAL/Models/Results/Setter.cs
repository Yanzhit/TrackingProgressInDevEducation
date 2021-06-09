namespace TrackingProgressInDevEducationDAL.Models.Results
{
    public class Setter : AResult
    {
        public Setter()
        {
        }

        public Setter(Setter setter) : base(setter)
        {
        }

        protected bool Equals(Setter other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }
    }
}