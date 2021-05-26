using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests
{
    public class GetByIdStudent : IQuery
    {
        public Type Type { get; }
        public string QueryName { get; }

        public GetByIdStudent()
        {
            Type = typeof(Students);
            QueryName = "GetByIdStudent";
        }
    }
}