using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL
{
    public abstract class Query
    {
        public string TypeName { get; set; }
        public string QueryName { get; set; }
    }
}