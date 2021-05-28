using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeTeams
    {
        
    }

    public class FacadeGetTeamById
    {
        public List<Teams> GetTeamById(int id)
        {
            GetTeamById getTeamById = new GetTeamById(id);
            return (List<Teams>)QuerySettings.QuerySet(getTeamById);
        }
    }
}