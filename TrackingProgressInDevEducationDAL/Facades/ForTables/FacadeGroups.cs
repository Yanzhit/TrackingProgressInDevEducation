using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeGroups
    {
        
    }

    public class FacadeUpdateGroupById
    {
        public List<Groups> UpdateGroupById(int id, string name, int courseId)
        {
            UpdateGroupById updateGroupById = new UpdateGroupById(id, name, courseId);
            return (List<Groups>)QuerySettings.QuerySet(updateGroupById);
        }
    }
}