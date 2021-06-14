using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface IGroups
    {
        IEnumerable<Group> GetGroups();
        IEnumerable<Group> NullifyGroups();
    }
}