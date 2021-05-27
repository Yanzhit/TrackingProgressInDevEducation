using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class NullifyStudents : IQuery
    {
        public Type Type { get; }
        public string Name { get;}
        public string Params { get; }

        public NullifyStudents()
        {
            Type = typeof(NullifyStudents);
            Name = GetType().Name;
            Params = "";
        }
    }
}