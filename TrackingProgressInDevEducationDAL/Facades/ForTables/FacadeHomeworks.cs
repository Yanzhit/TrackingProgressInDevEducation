using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeHomeworks
    {

    }

    public class FacadeGetHomeworkById
    {
        public List<Homeworks> GetHomeworkById(int id)
        {
            GetHomeworkById getHomeworkById = new GetHomeworkById(id);
            return (List<Homeworks>) QuerySettings.QuerySet(getHomeworkById);
        }
    }

    public class FacadeUpdateHomeworkById
    {
        public List<Homeworks> UpdateHomeworkById(string name, int id)
        {
            UpdateHomeworkById updateHomeworkById = new UpdateHomeworkById(name, id);
            return (List<Homeworks>) QuerySettings.QuerySet(updateHomeworkById);
        }
    }

}