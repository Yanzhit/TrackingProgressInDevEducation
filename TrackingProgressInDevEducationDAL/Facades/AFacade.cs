namespace TrackingProgressInDevEducationDAL.Facades
{
    public abstract class AFacade
    {
        protected readonly QueriesManager Manager = new();
    }
}