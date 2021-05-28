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

    public class FacadeGetLectorById
    {
        public List<Lectors> GetLectorById(int id)
        {
            GetLectorById getLectorById = new GetLectorById(id);
            return (List<Lectors>) QuerySettings.QuerySet(getLectorById);
        }
    }

    public class FacadeUpdateLectorById
    {
        public List<Lectors> UpdateLectorById(int id, string fullName)
        {
            UpdateLectorById updateLectorById = new UpdateLectorById(id, fullName);
            return (List<Lectors>) QuerySettings.QuerySet(updateLectorById);
        }
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