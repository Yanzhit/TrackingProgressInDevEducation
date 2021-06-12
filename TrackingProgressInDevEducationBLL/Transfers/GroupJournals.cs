using TrackingProgressInDevEducationBLL.Models.GroupJournal;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class GroupJournals : ATransfer
    {
        public GroupJournals GetVisitsByStudentJ()
        {
            Query = typeof(GetVisitsByStudentJQ);
            Base = typeof(GetVisitsByStudentJ);
            Answer = typeof(GetVisitsByStudentJA);
            return this;
        }
    }
}