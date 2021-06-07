using TrackingProgressInDevEducationDAL.Senders;


namespace TrackingProgressInDevEducationDAL
{
    public class QueriesManager
    {
        public Getter Getter => new();
        public Setter Setter => new();
        public Update Update => new();
        public Remove Remove => new();
    }
}