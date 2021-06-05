namespace TrackingProgressInDevEducationDAL.Models
{
    public abstract  class AbstractModel
    {
        public int Id { get; set; }
        protected AbstractModel()
        {
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return -1;
        }
    }
}