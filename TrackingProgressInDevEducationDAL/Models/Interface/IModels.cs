namespace TrackingProgressInDevEducationDAL.Models.Interface
{
    public interface IModels
    {
        public virtual bool Equals(object obj)
        {
            return false;
        }

        public virtual int GetHashCode()
        {
            return 0;
        }
    }
}