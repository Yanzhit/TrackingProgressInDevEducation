using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models.GroupInfo;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class GroupInfoA : AAnswer
    {
        public IEnumerable<GetAllStudentsByGroupA> GetAllStudentsByGroupA(IEnumerable<AbstractModel> model)
        {
            WriteTypes(new GroupInfos().GetAllStudentsByGroup());
            return (IEnumerable<GetAllStudentsByGroupA>)GetModelBaseSeveral(model);
        }
    }
}
