using System;

namespace TrackingProgressInDevEducationDAL.Requests.Interface
{
    public interface IQuery
    {
        Type Type { get; }
        string QueryName { get; }
    }
}