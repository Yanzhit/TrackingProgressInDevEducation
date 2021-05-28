using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeLectors
    {
        
    }

    public class FacadeGetLectorById
    {
        public List<Lectors> GetLectorById(int id)
        {
            GetLectorById getLectorById = new GetLectorById(id);
            return (List<Lectors>) QuerySettings.QuerySet(getLectorById);
        }
    }
}