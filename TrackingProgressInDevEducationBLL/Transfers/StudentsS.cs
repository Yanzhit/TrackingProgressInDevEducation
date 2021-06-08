using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class StudentsS : ATransfer
    {
        public StudentsS SetNewStudent()
        {
            Query = typeof(SetNewStudentA);
            Base = typeof(Student);
            Answer = typeof(SetNewStudentQ);
            return this;
        }
    }
}