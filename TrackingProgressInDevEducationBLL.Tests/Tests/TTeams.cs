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
        public Mock<ILectors> Mock;

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<ILectors>();
        }

        [TestCaseSource(typeof(ETeams), nameof(ETeams.SetNewTeam))]
        public void GetCities(SetTeamQ query, SetNewTeams expectedA, SetTeamA expected)
        {
            var model = (SetNewTeams)BLLManager.TeamsQ.SetNewTeam(SetTeamQ);
            Mock.Setup(mock => mock.SetNewTeam(model)).Returns(expectedA);
            var actual = BLLManager.TeamsA.SetNewTeam(expectedA);
            Assert.AreEqual(actual, expected);
        }
    }
}