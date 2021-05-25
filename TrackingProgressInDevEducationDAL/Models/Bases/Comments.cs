namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Comments
    {
        public string Text { get; set; }
        public int TypeId { get; set; }
        public int StudentId { get; set; }
        public int CreatedBy { get; set; }
    }
}