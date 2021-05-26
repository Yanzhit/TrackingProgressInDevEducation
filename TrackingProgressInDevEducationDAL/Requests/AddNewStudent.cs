using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests
{
    public class AddNewStudent : IQuery
    {
        public Type Type { get; }
        public string QueryName { get; }

        public AddNewStudent()
        {
            Type = typeof(Students);
            QueryName = "AddNewStudent";
        }
    }
}