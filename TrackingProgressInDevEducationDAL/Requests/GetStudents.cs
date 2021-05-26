using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests
{
    public class GetStudents : IQuery
    {
        public Type Type { get; }
        public string QueryName { get; }

        public GetStudents()
        {
            Type = typeof(Students);
            QueryName = "GetStudents";
        }
    }
}