using TrackingProgressInDevEducationBLL.Models.Group;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class Courses : ATransfer
    {
        public Courses GetAllCourses()
        {
            Query = typeof(SetCoursesQ);
            Base = typeof(Courses);
            Answer = typeof(SetCoursesA);
            return this;
        }
    }
}