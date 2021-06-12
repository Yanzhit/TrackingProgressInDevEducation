using TrackingProgressInDevEducationBLL.Models.GroupInfo;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class GroupInfosQ : AQuery
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
        public AbstractModel GetGroupByIdJ(GetGroupByIdJQ model)
        {
            WriteTypes(new GroupInfos().GetGroupByIdJ());
            return (AbstractModel)GetModelBaseSingle(model);
        }
    }
}
