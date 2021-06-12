using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.GroupJournal;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class GroupJournalsQ : AQuery
    {
        public AbstractModel GetVisitsByStudentJ(GetVisitsByStudentJQ model)
        {
            WriteTypes(new GroupJournals().GetVisitsByStudentJ());
            return GetModelBaseSingle(model);
        }
    }
}