using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class Groups : ATransfer
    {
        public Groups SetNewGroup()
        {
            Query = typeof(SetGroupQ);
            Base = typeof(Group);
            Answer = typeof(SetGroupA);
            return this;
        }
    }
}
