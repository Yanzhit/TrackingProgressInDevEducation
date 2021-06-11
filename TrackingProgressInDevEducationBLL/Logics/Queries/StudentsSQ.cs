using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.Students;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class StudentsSQ : AQuery
    {
        public AbstractModel GetAllStudents(EmptyQ model)
        {
            WriteTypes(new StudentsS().GetAllStudents());
            return GetModelBaseSingle(model);
        }
    }
}