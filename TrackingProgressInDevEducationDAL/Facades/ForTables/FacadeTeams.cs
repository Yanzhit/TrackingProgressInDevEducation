using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeTeams
    {
        
    }

    public class FacadeAddNewTeam
    {
        public List<Teams> AddNewTeam(string name)
        {
            AddNewTeam addNewTeam = new AddNewTeam(name);
            return (List<Teams>) QuerySettings.QuerySet(addNewTeam);
        }
    }
}