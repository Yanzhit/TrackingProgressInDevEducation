using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests
{
    public class RemoveStudents : IQuery
    {
        public Type Type { get;}
        public string Name { get;}
        public string Params { get; }

        public RemoveStudents()
        {
            Type = typeof(Students);
            Name  = "RemoveStudents";
            Params = "";
        }
    }
}