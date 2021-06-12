using TrackingProgressInDevEducationBLL.Models.GroupInfo;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class GroupInfos : ATransfer
    {
        public GroupInfos GetAllStudentsByGroup()
        {
            Query = typeof(GetAllStudentsByGroupQ);
            Base = typeof(GetAllStudentsByGroup);
            Answer = typeof(GetAllStudentsByGroupA);
            return this;
        }
        public GroupInfos GetAllCoursesByGroup()
        {
            Query = typeof(GetAllCoursesByGroupQ);
            Base = typeof(GetAllCoursesByGroup);
            Answer = typeof(GetAllCoursesByGroupA);
            return this;
        }
        public GroupInfos GetGroupByIdJ()
        {
            Query = typeof(GetGroupByIdJQ);
            Base = typeof(GetGroupByIdJ);
            Answer = typeof(GetGroupByIdJA);
            return this;
        }
    }
}