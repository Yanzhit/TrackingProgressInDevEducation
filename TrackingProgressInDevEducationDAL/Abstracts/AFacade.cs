namespace TrackingProgressInDevEducationDAL.Abstracts
{
    public abstract class AFacade
    {
        protected readonly QueriesManager Manager = new();
    }
}