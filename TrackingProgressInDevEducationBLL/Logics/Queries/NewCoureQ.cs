using TrackingProgressInDevEducationBLL.Models.Course;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class NewCoureQ : AQuery
    {
        public AbstractModel SetNewCourse(SetNewCoursesQ query)
        {
            WriteTypes(new Courses().SetNewCourse());
            return GetModelBaseSingle(query);
        }
    }
}
