using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Tests.Expected.Students;

namespace TrackingProgressInDevEducationDAL.Tests.Tests
{
    public class Primer
    {
        private readonly PreparationDB _pDb= new();
        [TestCaseSource(typeof(EStudents))]
        public void GetStudentsTest(IQuery query, object expected)
        {
            _pDb.Nullify(query.Type);
            _pDb.Filling(query.Type);
            //List<Student> actual = (List<Student>)QuerySettings.QuerySet(query);
            //Assert.AreEqual(expected, actual);
        }
    }
}