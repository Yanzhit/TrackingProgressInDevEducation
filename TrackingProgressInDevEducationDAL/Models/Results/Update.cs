namespace TrackingProgressInDevEducationDAL.Models.Results
{
    public class Update : AResult
    {
        public Update(int id):base(id)
        {
            Id = id;
        }
    }
}