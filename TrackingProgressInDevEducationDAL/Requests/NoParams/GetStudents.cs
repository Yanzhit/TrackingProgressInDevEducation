using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class GetStudents : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetStudents()
        {
            Type = typeof(Students);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}