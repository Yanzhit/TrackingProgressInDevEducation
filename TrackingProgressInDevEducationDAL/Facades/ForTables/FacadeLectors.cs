using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeLectors
    {
        
    }

    public class FacadeRemoveLectorById
    {
        public List<Lectors> RemoveLectorById(int id)
        {
            RemoveLectorById removeLectorById = new RemoveLectorById(id);
            return (List<Lectors>) QuerySettings.QuerySet(removeLectorById);
        }
    }
}