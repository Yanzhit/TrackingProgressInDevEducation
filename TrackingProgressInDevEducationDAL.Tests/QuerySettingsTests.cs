using System.Collections.Generic;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class QuerySettingsTests
    {
        private PreparationDB _pDB= new PreparationDB();
        [TestCaseSource(typeof(StudentsDTO))]
        public void GetStudentsTest(IQuery query, List<Students> expected)
        {
            _pDB.Nullify(query.Type);
            List<Students> actual = (List<Students>)QuerySettings.QuerySet(query);
            Assert.AreEqual(expected, actual);
        }
    }
}