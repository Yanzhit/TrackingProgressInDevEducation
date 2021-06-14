using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface ICourses
    {
        Course SetNewCourse(Course course);
        IEnumerable<Course> GetAllCourses();
        IEnumerable<Course> NullifyCourses();
    }
}