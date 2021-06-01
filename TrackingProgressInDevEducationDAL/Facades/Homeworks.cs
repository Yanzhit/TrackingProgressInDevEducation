using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Homeworks
    {
        private static readonly QHomework Query = new();
        //public static IEnumerable<Homework> GetHomeworkById(int id)
        //{
        //    return (List<Homework>) QuerySettings.QuerySet(Query.GetHomeworkById(id));
        //}
        //public static List<Homework> UpdateHomeworkById(string name, int id)
        //{
        //    return (List<Homework>) QuerySettings.QuerySet(Query.UpdateHomeworkById(name, id));
        //}
        //public static List<Homework> RemoveHomeworksById(int id)
        //{
        //    return (List<Homework>) QuerySettings.QuerySet(Query.RemoveHomeworksById(id));
        //}
        //public static Homework CreateNewHomeworks(string name)
        //{
        //    return (Homework) QuerySettings.QuerySet(Query.SetNewHW(name));
        //}
        //public static List<Homework> NullifyHWs()
        //{
        //    return (List<Homework>) QuerySettings.QuerySet(Query.NullifyHWs());
        //}
    }
}