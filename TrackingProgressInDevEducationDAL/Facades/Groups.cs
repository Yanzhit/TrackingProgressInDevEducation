using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Groups
    {
        private readonly QGroup Query = new();
        //public static IEnumerable<Group> GetGroups()
        //{
        //    return (List<Group>) QuerySettings.QuerySet(Query.GetGroups());
        //}
        //public static Group SetNewGroup(string name, int courseId)
        //{
        //    return (Group)QuerySettings.QuerySet(Query.SetNewGroup(name, courseId));
        //}
        //public static IEnumerable<Group> GetGroupById(int id)
        //{
        //    return (List<Group>)QuerySettings.QuerySet(Query.GetGroupById(id));
        //}
        //public static IEnumerable<Group> RemoveGroupById(int id)
        //{
        //    return (List<Group>)QuerySettings.QuerySet(Query.RemoveGroupById(id));
        //}
        //public static IEnumerable<Group> UpdateGroupById(int id, string name, int courseId)
        //{
        //    return (List<Group>)QuerySettings.QuerySet(Query.UpdateGroupById(id, name, courseId));
        //}
        //public static IEnumerable<Group> NullifyGroups()
        //{
        //    return (List<Group>)QuerySettings.QuerySet(Query.NullifyGroups());
        //}
    }
    

    //public class FacadeGetGroupsByLector
    //{
    //    public List<Group> GetGroupsByLector(int lectorId)
    //    {
    //        GetGroupsByLector getGroupsByLector = new GetGroupsByLector(lectorId);
    //        return (List<Group>)QuerySettings.QuerySet(Query.GetGroupsByLector);
    //    }
    //}
}