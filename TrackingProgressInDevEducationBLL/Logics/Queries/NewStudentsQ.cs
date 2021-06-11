using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class NewStudentsQ : AQuery
    {
        public AbstractModel SetNewStudent(SetNewStudentQ model)
        {
            WriteTypes(new NewStudents().SetNewStudent());
            return GetModelBaseSingle(model);
        }

        public AbstractModel GetCities(EmptyQ model)
        {
            WriteTypes(new NewStudents().GetCities());
            return GetModelBaseSingle(model);
        }
        
        public AbstractModel GetGroups(EmptyQ model)
        {
            WriteTypes(new NewStudents().GetGroups());
            return GetModelBaseSingle(model);
        }
    }
}