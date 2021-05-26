using System;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL
{
    public abstract class Query
    {
        public Type Type { get; set; }
        public string QueryName { get; set; }
    }
}