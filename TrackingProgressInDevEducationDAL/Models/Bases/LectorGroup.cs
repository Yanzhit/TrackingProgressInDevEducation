using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class LectorGroup : IModels
    {
        public int LectorId { get; set; }
        public int GroupId { get; set; }
    }
}