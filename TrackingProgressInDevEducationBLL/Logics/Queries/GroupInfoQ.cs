using TrackingProgressInDevEducationBLL.Models.GroupInfo;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class GroupInfoQ : AQuery
    {
        public AbstractModel GetAllStudentsByGroup(GetAllStudentsByGroupQ model)
        {
            WriteTypes(new GroupInfos().GetAllStudentsByGroup());
            return (AbstractModel)GetModelBaseSingle(model);
        }
        public AbstractModel GetAllCoursesByGroup(GetAllCoursesByGroupQ model)
        {
            WriteTypes(new GroupInfos().GetAllCoursesByGroup());
            return (AbstractModel)GetModelBaseSingle(model);
        }
    }
}
