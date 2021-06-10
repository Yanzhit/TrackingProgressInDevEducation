using TrackingProgressInDevEducationBLL.Models.GroupInfo;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class GroupInfos : ATransfer
    {
        public GroupInfos GetAllStudentsByGroup()
        {
            Query = typeof(GetAllStudentsByGroupQ);
            Base = typeof(Student);
            Answer = typeof(GetAllStudentsByGroupA);
            return this;
        }
    }
}