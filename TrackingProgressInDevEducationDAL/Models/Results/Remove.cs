namespace TrackingProgressInDevEducationDAL.Models.Results
{
    public class Remove : AResult
    {
        public Remove()
        {
        }

        public Remove(int id):base(id)
        {
            Id = id;
        }
    }
}