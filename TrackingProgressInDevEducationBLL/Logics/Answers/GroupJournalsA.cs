using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.GroupJournal;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class GroupJournalsA : AAnswer
    {
        public IEnumerable<GetVisitsByStudentJA> GetVisitsByStudentJ(IEnumerable<AbstractModel> model)
        {
            WriteTypes(new GroupJournals().GetVisitsByStudentJ());
            return (IEnumerable<GetVisitsByStudentJA>)GetModelBaseSeveral(model);
        }
    }
}