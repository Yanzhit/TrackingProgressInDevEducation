using System.Collections.Generic;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationBLL.Facades.ForTables
{
    public class FacadeLectors
    {
        private static readonly QLector Query = new();
        //public static IEnumerable<Lector> GetLectors()
        //{
        //    return (List<Lector>) QuerySettings.QuerySet(Query.GetLectors());
        //}
        public static Lector SetNewLector(string fullName, string email, string password)
        {
            return (Lector)QuerySettings.QuerySet(Query.SetNewLector(fullName, email, password));
        }
        public static IEnumerable<Lector> GetLectorById(int id)
        {
            return (List<Lector>) QuerySettings.QuerySet(Query.GetLectorById(id));
        }
        //public static IEnumerable<Lector> UpdateLectorById(int id, string fullName)
        //{
        //    return (List<Lector>) QuerySettings.QuerySet(Query.UpdateLectorById(id, fullName));
        //}
        //public static List<Lector> RemoveLectorById(int id)
        //{
        //    return (List<Lector>) QuerySettings.QuerySet(Query.RemoveLectorById(id));
        //}
    }
}