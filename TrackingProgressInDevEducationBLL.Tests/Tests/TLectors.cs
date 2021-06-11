using Moq;
using NUnit.Framework;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Tests.Expected;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Tests
{
    public class TLectors
    {
        public Mock<ILectors> Mock;
        public OperationLogics Operation;
        public readonly BLLManager BLLManager = new BLLManager();

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<ILectors>();
        }

        [TestCaseSource(typeof(ELectors), nameof(ELectors.GetLectorByLoginAndPassword))]
        public void Qqq(GetLectorQ query, Lector expectedA, GetLectorA expected)
        {
            var model = (Lector)BLLManager.SignInsQ.GetLectorByLoginAndPassword(query);

            Lector modelReturned = (Lector)Mock.Setup(mock => mock.GetLectorByLoginAndPassword(model)).Returns(expectedA);

            var actual = BLLManager.SignInsA.GetLectorByLoginAndPassword(modelReturned);
            Assert.AreEqual(actual, expected);

        }
    }
}