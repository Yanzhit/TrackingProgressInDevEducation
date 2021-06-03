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
    }
}