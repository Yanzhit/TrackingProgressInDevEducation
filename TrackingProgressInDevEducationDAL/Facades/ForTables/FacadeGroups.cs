using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.NoParams;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeGroups
    {
        
    }

    public class FacadeGetGroups
    {
        public List<Groups> GetGroups()
        {
            GetGroups getGroups = new GetGroups();
            return (List<Groups>)QuerySettings.QuerySet(getGroups);
        }
    }
}