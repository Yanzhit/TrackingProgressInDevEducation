using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models.GroupInfo;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class GroupInfosA : AAnswer
    {
        public IEnumerable<GetAllStudentsByGroupA> GetAllStudentsByGroupA(IEnumerable<AbstractModel> model)
        {
            WriteTypes(new GroupInfos().GetAllStudentsByGroup());
            return (IEnumerable<GetAllStudentsByGroupA>)GetModelBaseSeveral(model);
        }
        public IEnumerable<GetAllCoursesByGroupA> GetAllCoursesByGroupA(IEnumerable<AbstractModel> model)
        {
            WriteTypes(new GroupInfos().GetAllCoursesByGroup());
            return (IEnumerable<GetAllCoursesByGroupA>)GetModelBaseSeveral(model);
        }
        public GetGroupByIdJA GetGroupByIdJA(AbstractModel model)
        {
            WriteTypes(new GroupInfos().GetGroupByIdJ());
            return (GetGroupByIdJA)GetModelBaseSingle(model);
        }
    }
}