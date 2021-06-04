namespace TrackingProgressInDevEducationDAL.Models.Results
{
    public class Setter : AResult
    {
        public Setter()
        {
        }

        public Setter(int id):base(id)
        {
            Id = id;
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