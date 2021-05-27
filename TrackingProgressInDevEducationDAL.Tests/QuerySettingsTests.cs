using System.Collections.Generic;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class QuerySettingsTests
    {
        [TestCaseSource(typeof(ConnectionDTO))]
        public void GetStudentsTest(IQuery query, List<Students> expected)
        {
            List<Students> actual = (List<Students>)QuerySettings.QuerySet(query);
            Assert.AreEqual(expected, actual);
        }
    }
}