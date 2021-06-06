namespace TrackingProgressInDevEducationBLL.Models
{
    public abstract class ADTO
    {
        protected ADTO()
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