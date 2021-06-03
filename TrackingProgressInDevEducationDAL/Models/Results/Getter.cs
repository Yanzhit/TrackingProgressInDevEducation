namespace TrackingProgressInDevEducationDAL.Models.Results
{
    public class Getter : AResult
    {
        public Getter()
        {
        }

        public Getter(int id):base(id)
        {
            Id = id;
        }
    }
}