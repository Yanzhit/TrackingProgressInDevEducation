using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeLectors
    {
        
    }

    public class FacadeUpdateLectorById
    {
        public List<Lectors> UpdateLectorById(int id, string fullName)
        {
            UpdateLectorById updateLectorById = new UpdateLectorById(id, fullName);
            return (List<Lectors>) QuerySettings.QuerySet(updateLectorById);
        }
    }
}