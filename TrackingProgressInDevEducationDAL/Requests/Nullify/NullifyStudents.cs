using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyStudents : IQuery
    {
        public Type Type { get; }
        public string Name { get;}
        public string Params { get; }

        public NullifyStudents()
        {
            Type = typeof(Students);
            Name = GetType().Name;
            Params = "";
        }
    }
}