using TrackingProgressInDevEducationBLL.BLLModels;
using TrackingProgressInDevEducationBLL.BLLModels.Bases;
using TrackingProgressInDevEducationBLL.BLLModels.SignIn;

namespace TrackingProgressInDevEducationBLL.Tasks
{
    public class TaskPreparing
    {
        public AbstractBModel PreparingBaseModels(AbstractBModel model)
        {
            Mapper map = new Mapper();
            var ddd = map.Map<AbstractBModel, BLector>(model);
            return ddd;
        }
    }
}