namespace TrackingProgressInDevEducationDAL.Models
{
    public abstract  class AbstractModel
    {
        public int Id { get; }
        protected AbstractModel()
        {
        }
        protected AbstractModel(int id)
        {
            Id = id;
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