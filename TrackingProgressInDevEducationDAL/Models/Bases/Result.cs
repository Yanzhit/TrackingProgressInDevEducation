namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Result : AbstractModel
    {
        public int Id { get; set; }

        public Result()
        {
        }
        
        public Result(int id)
        {
            Id = id;
        }
    }
}