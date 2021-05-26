using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests
{
    public class GetByIdStudent : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetByIdStudent(int id = 0)
        {
            Type = typeof(Students);
            Name = "GetByIdStudent";
            Params = $"{id}";
        }
    }
}