using System;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataLectors
    {
        public string FullName { get; }

        public DataLectors(string fullName)
        {
            FullName = fullName;
        }
    }
}