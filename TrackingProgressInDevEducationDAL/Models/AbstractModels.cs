namespace TrackingProgressInDevEducationDAL.Models
{
    public abstract  class AbstractModels
    {
        protected AbstractModels()
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