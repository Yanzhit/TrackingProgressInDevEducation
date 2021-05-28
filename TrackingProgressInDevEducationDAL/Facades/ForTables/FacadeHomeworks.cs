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

    public class FacadeRemoveHomeworksById
    {
        public List<Homeworks> RemoveHomeworksById(int id)
        {
            RemoveHomeworksById removeHomeworksById = new RemoveHomeworksById(id);
            return (List<Homeworks>) QuerySettings.QuerySet(removeHomeworksById);
        }
    }
}