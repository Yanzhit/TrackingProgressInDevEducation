using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface IHWGroups
    {
        HWGroup SetNewHWGroup(HWGroup hwGroup);
        IEnumerable<HWGroup> NullifyHWGroup();
    }
}