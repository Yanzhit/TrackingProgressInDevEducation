using TrackingProgressInDevEducationDAL;

namespace TrackingProgressInDevEducationBLL.Facades
{
    public abstract class AFacade
    {
        protected readonly Mappers Mappers = new();
        protected readonly TrackingProgressInDevEducationDAL.DALManager Manager = new();
    }
}