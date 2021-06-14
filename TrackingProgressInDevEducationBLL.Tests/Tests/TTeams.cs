using Moq;
using NUnit.Framework;
using TrackingProgressInDevEducationBLL.Models.Team;
using TrackingProgressInDevEducationBLL.Tests.Expecteds;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Tests.Tests
{
    public class TTeams : AbstractTest
    {
        public Mock<IJoins> Mock;

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<IJoins>();
        }

        [TestCaseSource(typeof(ETeams), nameof(ETeams.SetNewTeam))]
        public void GetCities(SetTeamQ query, SetNewTeams expectedA, SetTeamA expected)
        {
            var model = (SetNewTeams)BLLManager.TeamsQ.SetNewTeam(query);
            Mock.Setup(mock => mock.SetNewTeams(model)).Returns(expectedA);
            var actual = BLLManager.TeamsA.SetNewTeam(expectedA);
            Assert.AreEqual(actual, expected);
        }
    }
}