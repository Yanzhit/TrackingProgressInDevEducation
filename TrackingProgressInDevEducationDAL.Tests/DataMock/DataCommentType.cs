using System;
using System.Security.Cryptography.X509Certificates;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataCommentType
    {
        public string Name { get; }

        public DataCommentType(string name)
        {
            Name = name;
        }
    }
}