using Moq;
using NUnit.Framework;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Tests.Expecteds;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Tests
{
    public class TStudets : AbstractTest
    {
        public Mock<IStudents> Mock;

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<IStudents>();
        }

        [TestCaseSource(typeof(EStudets), nameof(EStudets.SetNewStudent))]
        public void GetCities(SetNewStudentQ query, Student expectedA, SetNewStudentA expected)
        {
            var model = (Student)BLLManager.NewStudentQ.SetNewStudent(query);
            Mock.Setup(mock => mock.SetNewStudent(model)).Returns(expectedA);
            var actual = BLLManager.NewStudentA.SetNewStudent(expectedA);
            Assert.AreEqual(actual, expected);
        }
    }
}