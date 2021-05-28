using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeGroups
    {
        
    }

    public class FacadeRemoveGroupById
    {
        public List<Groups> RemoveGroupById(int id)
        {
            RemoveGroupById removeGroupById = new RemoveGroupById(id);
            return (List<Groups>)QuerySettings.QuerySet(removeGroupById);
        }
    }
}