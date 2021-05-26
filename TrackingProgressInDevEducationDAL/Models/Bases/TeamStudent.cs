using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class TeamStudent : IModels
    {
        public int TeamId { get; set; }
        public int StudentId { get; set; }
    }
}