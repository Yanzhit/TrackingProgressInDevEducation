using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class StudentsS : ATransfer
    {
        public StudentsS SetNewStudent()
        {
            Query = typeof(SetNewStudentQ);
            Base = typeof(Student);
            Answer = typeof(SetNewStudentA);
            return this;
        }
    }
}