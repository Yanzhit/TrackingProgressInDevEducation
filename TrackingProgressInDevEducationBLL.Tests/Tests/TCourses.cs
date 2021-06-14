using Moq;
using NUnit.Framework;
using TrackingProgressInDevEducationBLL.Models.Course;
using TrackingProgressInDevEducationBLL.Tests.Expecteds;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Tests
{
    public class TCourses : AbstractTest
    {
        public Mock<ILectors> Mock;

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<ILectors>();
        }
        [TestCaseSource(typeof(ECourses), nameof(ECourses.GetCities))]
        public void SetNewCourse(SetNewCoursesQ query, Course expectedA, SetNewCoursesA expected)
        {
            var model = (Course)BLLManager.NewCoureQ.SetNewCourse(query);
            Mock.Setup(mock => mock.SetNewCourse(model)).Returns(expectedA);
            var actual = BLLManager.SenNewCourse.SetNewCourse(modelReturned);
            Assert.AreEqual(actual, expected);
        }
    }
}