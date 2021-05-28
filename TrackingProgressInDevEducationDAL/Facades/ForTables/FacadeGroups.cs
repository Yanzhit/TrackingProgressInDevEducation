using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeGroups
    {
        
    }

    public class FacadeGetGroupById
    {
        public List<Groups> GetGroupById(int id)
        {
            GetGroupById getGroupById = new GetGroupById(id);
            return (List<Groups>)QuerySettings.QuerySet(getGroupById);
        }
    }
}