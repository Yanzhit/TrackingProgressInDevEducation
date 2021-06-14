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
    public class TGroups : AbstractTest
    {
        public Mock<IGroups> Mock;

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<IGroups>();
        }
        [TestCaseSource(typeof(EGroups), nameof(EGroups.GetGroups))]
        public void GetGroups(EmptyQ query, List<Group> expectedA, IEnumerable<GetGroupsA> expected)
        {
            var model = (Group)BLLManager.CityQ.GetGroups(query);
            Mock.Setup(mock => mock.GetGroups()).Returns(expectedA);
            var actual = (List<GetGroupsA>)BLLManager.CityA.GetGroups(expectedA);
            Assert.AreEqual(actual, expected);
        }
    }
}