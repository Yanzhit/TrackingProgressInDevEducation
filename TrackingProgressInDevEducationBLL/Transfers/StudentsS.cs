using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Models.Students;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class StudentsS : ATransfer
    {
        public StudentsS GetAllStudents()
        {
            Query = typeof(EmptyQ);
            Base = typeof(Student);
            Answer = typeof(GetAllStudentsA);
            return this;
        }
    }
}