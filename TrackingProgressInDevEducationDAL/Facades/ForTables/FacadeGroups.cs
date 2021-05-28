using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;
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

    public class FacadeAddNewGroup
    {
        public List<Groups> AddNewGroup(string name, int courseId)
        {
            AddNewGroup addNewGroup = new AddNewGroup(name, courseId);
            return (List<Groups>)QuerySettings.QuerySet(addNewGroup);
        }
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