using System;

namespace TrackingProgressInDevEducationDAL.Requests.Interface
{
    public interface IQuery
    {
        Type Type { get; }
        public TypeQueries TypeQueries { get; set; }
        string Name { get; set; }
        string Params { get; set; }
    }
}