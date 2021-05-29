using System.Collections.Generic;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables.TableGroups;
using TrackingProgressInDevEducationDAL.Requests.Others;

namespace TrackingProgressInDevEducationBLL.Facades.ForTables
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

    public class FacadeGetGroupsByLector
    {
        public List<Groups> GetGroupsByLector(int lectorId)
        {
            GetGroupsByLector getGroupsByLector = new GetGroupsByLector(lectorId);
            return (List<Groups>)QuerySettings.QuerySet(getGroupsByLector);
        }
    }

    public class FacadeRemoveGroupById
    {
        public List<Groups> RemoveGroupById(int id)
        {
            RemoveGroupById removeGroupById = new RemoveGroupById(id);
            return (List<Groups>)QuerySettings.QuerySet(removeGroupById);
        }
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