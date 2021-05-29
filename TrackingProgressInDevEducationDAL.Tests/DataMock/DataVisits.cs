using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataVisits
    {
        public bool VisitStatus { get; }
        public int StudentId { get; }
        public int LectionId { get; }

        public DataVisits(bool visitStatus, int studentId, int lectionId)
        {
            VisitStatus = visitStatus;
            StudentId = studentId;
            LectionId = lectionId;
        }
    }
}