using System.Collections.Generic;
using System.Globalization;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeTeams
    {
        
    }

    public class FacadeUpdateTeamById
    {
        public List<Teams> UpdateTeamById(int id, string name)
        {
            UpdateTeamById updateTeamById = new UpdateTeamById(id, name);
            return (List<Teams>) QuerySettings.QuerySet(updateTeamById);
        }
    }
}