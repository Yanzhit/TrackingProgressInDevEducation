using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeTeams
    {
        
    }

    public class FacadeRemoveTeamById
    {
        public List<Teams> RemoveTeamById(int id)
        {
            RemoveTeamById removeTeamById = new RemoveTeamById(id);
            return (List<Teams>) QuerySettings.QuerySet(removeTeamById);
        }
    }
}