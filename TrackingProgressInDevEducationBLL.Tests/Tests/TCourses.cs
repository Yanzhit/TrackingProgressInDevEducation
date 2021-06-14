using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models.Course;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Tests.Expecteds;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Tests
{
    public class TCourses : AbstractTest
    {
        public Mock<ICourses> Mock;

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<ICourses>();
        }
        [TestCaseSource(typeof(ECourses), nameof(ECourses.SetNewCourse))]
        public void SetNewCourse(SetNewCoursesQ query, Course expectedA, SetNewCoursesA expected)
        {
            var model = (Course)BLLManager.NewCoureQ.SetNewCourse(query);
            Mock.Setup(mock => mock.SetNewCourse(model)).Returns(expectedA);
            var actual = BLLManager.SenNewCourse.SetNewCourse(expectedA);
            Assert.AreEqual(actual, expected);
        }
        [TestCaseSource(typeof(ELectors), nameof(ELectors.GetAllCurses))]
        public void GetAllCurses(SetCoursesQ query, List<Course> expectedA, IEnumerable<SetCoursesA> expected)
        {
            var model = BLLManager.CoursesQ.GetAllCourses(query);
            Mock.Setup(mock => mock.GetAllCourses()).Returns(expectedA);
            var actual = (List<SetCoursesA>)BLLManager.CoursesA.GetSetCourses(expectedA);
            Assert.AreEqual(actual, expected);
        }
    }
}