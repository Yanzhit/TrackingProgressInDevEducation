using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeLectors
    {
        
    }

    public class FacadeAddNewLector
    {
        public List<Lectors> AddNewLector(string fullName)
        {
            AddNewLector addNewLector = new AddNewLector(fullName);
            return (List<Lectors>)QuerySettings.QuerySet(addNewLector);
        }
    }
}