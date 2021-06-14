using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Tests.Expecteds;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Tests
{
    public class TStudets : AbstractTest
    {
        public Mock<ITStudents> Mock;

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<ITStudents>();
        }

        [TestCaseSource(typeof(EStudets), nameof(EStudets.GetCities))]
        public void GetCities(SetNewStudentQ query, Student expectedA, SetNewStudentA expected)
        {
            var model = (Student)BLLManager.NewStudentQ.SetNewStudent(query);
            Mock.Setup(mock => mock.GetCities(model)).Returns(expectedA);
            var actual = BLLManager.NewStudentA.SetNewStudent(expectedA);
            Assert.AreEqual(actual, expected);
        }
    }
}