using System;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class GroupPage : ITransfer
    {
        public Type Query { get; set; } = typeof(GroupQuery);
        public Type Base { get; set; } = typeof(Group);
        public Type Answer { get; set; } = typeof(GroupAnswer);
    }
}
