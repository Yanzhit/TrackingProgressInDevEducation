namespace TrackingProgressInDevEducationBLL.BLLModels
{
    public class AbstractBModel
    {
        public int Id { get; set; }
        protected AbstractBModel()
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