using Moq;
using NUnit.Framework;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Tests.Expecteds;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Tests
{
    public class TLectors
    {
        public Mock<ILectors> Mock;
        public BLLManager BLLManager;

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<ILectors>();
            BLLManager = new BLLManager();
        }

        [TestCaseSource(typeof(ELectors), nameof(ELectors.GetLectorByLoginAndPassword))]
        public void GetLectorByLoginAndPasswor(GetLectorQ query, Lector expectedA, GetLectorA expected)
        {
            var model = (Lector) BLLManager.SignInsQ.GetLectorByLoginAndPassword(query);

            Mock.Setup(mock => mock.GetLectorByLoginAndPassword(model)).Returns(expectedA);

            var actual = BLLManager.SignInsA.GetLectorByLoginAndPassword(expectedA);
            Assert.AreEqual(actual, expected);
        }
    }
}