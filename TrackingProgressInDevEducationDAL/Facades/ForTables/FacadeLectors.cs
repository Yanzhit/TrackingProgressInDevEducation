using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.NoParams;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeLectors
    {
        
    }

    public class FacadeGetLectors
    {
        public List<Lectors> GetLectors()
        {
            GetLectors getLectors = new GetLectors();
            return (List<Lectors>)QuerySettings.QuerySet(getLectors);
        }
    }
}