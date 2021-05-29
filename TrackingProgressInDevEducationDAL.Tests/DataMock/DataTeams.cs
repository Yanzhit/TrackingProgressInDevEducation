using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataTeams
    {
        public string Name { get;}

        public DataTeams(string name)
        {
            Name = name;
        }
    }
}