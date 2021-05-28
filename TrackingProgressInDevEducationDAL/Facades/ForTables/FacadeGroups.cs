using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeGroups
    {
        
    }

    public class FacadeGetGroupsByLector
    {
        public List<Groups> GetGroupsByLector(int lectorId)
        {
            GetGroupsByLector getGroupsByLector = new GetGroupsByLector(lectorId);
            return (List<Groups>)QuerySettings.QuerySet(getGroupsByLector);
        }
    }
}