using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeGroups
    {
        
    }

    public class FacadeAddNewGroup
    {
        public List<Groups> AddNewGroup(string name, int courseId)
        {
            AddNewGroup addNewGroup = new AddNewGroup(name, courseId);
            return (List<Groups>)QuerySettings.QuerySet(addNewGroup);
        }
    }
}