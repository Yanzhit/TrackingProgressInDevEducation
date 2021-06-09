namespace TrackingProgressInDevEducationDAL.Models.Results
{
    public abstract class AResult : AbstractModel
    {
        public AResult()
        {
        }
        
        public AResult(AResult result) : base(result)
        {
        }
        public override bool Equals(object obj)
        {
            return Equals((AResult)obj);
        }

        protected bool Equals(AResult other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }
    }
}