using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.NoParams;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeTeams
    {

    }

    public class FacadeGetTeams
    {
        public List<Teams> GetTeams()
        {
            GetTeams getTeams = new GetTeams();
            return (List<Teams>) QuerySettings.QuerySet(getTeams);
        }
    }
}