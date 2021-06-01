using System.Collections.Generic;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class QuerySettingsTests
    {
        private readonly PreparationDB _pDb= new();
        [TestCaseSource(typeof(StudentsDTO))]
        public void GetStudentsTest(IQuery query, List<Student> expected)
        {
            _pDb.Nullify(query.Type);
            _pDb.Filling(query.Type);
            //List<Student> actual = (List<Student>)QuerySettings.QuerySet(query);
            //Assert.AreEqual(expected, actual);
        }
    }
}