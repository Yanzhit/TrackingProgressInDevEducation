using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class Groups : ATransfer
    {
        public Groups SetNewGroup()
        {
            Query = typeof(SetGroupQ);
            Base = typeof(SetNewGroupJ);
            Answer = typeof(SetGroupA);
            return this;
        }
    }
}
