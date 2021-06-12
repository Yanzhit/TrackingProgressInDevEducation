using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Models.Students;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class StudentsS : ATransfer
    {
        public StudentsS GetAllStudents()
        {
            Query = typeof(EmptyQ);
            Base = typeof(GetAllStudentsJ);
            Answer = typeof(GetAllStudentsA);
            return this;
        }
    }
}