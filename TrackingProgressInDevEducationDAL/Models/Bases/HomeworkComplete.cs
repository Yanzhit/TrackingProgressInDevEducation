using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class HomeworkComplete : IModels
    {
        public int HomeworkId { get; set; }
        public int StudentId { get; set; }
        public int Status { get; set; }
    }
}