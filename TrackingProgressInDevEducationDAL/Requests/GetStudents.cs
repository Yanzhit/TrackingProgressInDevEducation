using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests
{
    public class GetStudents : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public GetStudents()
        {
            Type = typeof(Students);
            Name = "GetStudents";
            Command = "select * from [Students]";
        }
    }
}