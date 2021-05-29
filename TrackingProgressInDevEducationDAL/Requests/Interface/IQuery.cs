using System;

namespace TrackingProgressInDevEducationDAL.Requests.Interface
{
    public interface IQuery
    {
        Type Type { get;  }
        string Name { get; set; }
        string Params { get; set; }
    }
}