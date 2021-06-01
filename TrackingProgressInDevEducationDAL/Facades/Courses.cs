using TrackingProgressInDevEducationDAL.Requests.Tables;
using TrackingProgressInDevEducationDAL.Abstarcts;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Courses : AFacade
    {
        public QCourse Query { get; set; }
    }
}