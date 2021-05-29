using System.Collections.Generic;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class QuerySettingsTests
    {
        private readonly PreparationDB _pDB= new();
        [TestCaseSource(typeof(StudentsDTO))]
        public void GetStudentsTest(IQuery query, List<Student> expected)
        {
            _pDB.Nullify(query.Type);
            List<Student> actual = (List<Student>)QuerySettings.QuerySet(query);
            Assert.AreEqual(expected, actual);
        }
    }
}