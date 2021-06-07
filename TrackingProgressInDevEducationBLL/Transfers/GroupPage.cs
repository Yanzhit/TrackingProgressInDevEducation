using System;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class GroupPage : ATransfer
    {
        public GroupPage SetNewGroup()
        {
            Query = typeof(QSetGroup);
            Base = typeof(Group);
            Answer = typeof(ANewGroup);
            return this;
        }
    }
}
