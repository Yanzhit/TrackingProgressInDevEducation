using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests
{
    public class GetByIdStudent : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public GetByIdStudent()
        {
            Type = typeof(Students);
            Name = "GetByIdStudent";
            Command = "";
        }
    }
}