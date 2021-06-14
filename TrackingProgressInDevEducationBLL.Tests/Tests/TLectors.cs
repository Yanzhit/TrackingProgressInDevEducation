using Moq;
using NUnit.Framework;
using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Models.Verification;
using TrackingProgressInDevEducationBLL.Tests.Expecteds;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Tests
{
    public class TLectors : AbstractTest
    {
        public Mock<ILectors> Mock;

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<ILectors>();
        }

        [TestCaseSource(typeof(ELectors), nameof(ELectors.GetLectorByLoginAndPassword))]
        public void GetLectorByLoginAndPasswor(GetLectorQ query, Lector expectedA, GetLectorA expected)
        {
            var model = (Lector) BLLManager.SignInsQ.GetLectorByLoginAndPassword(query);

            Mock.Setup(mock => mock.GetLectorByLoginAndPassword(model)).Returns(expectedA);

            var actual = BLLManager.SignInsA.GetLectorByLoginAndPassword(expectedA);
            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(ELectors), nameof(ELectors.SetNewLector))]
        public void SetNewLector(SetLectorQ query, Lector expectedA, SetLectorA expected)
        {
            var model = (Lector)BLLManager.RegistrationsQ.SetNewLector(query);
            Mock.Setup(mock => mock.SetNewLector(model)).Returns(expectedA);
            var actual = BLLManager.RegistrationsA.SetNewLector(expectedA);
            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(ELectors), nameof(ELectors.UpdateAcrivationLector))]
        public void UpdateAcrivationLector(UpdLectorQ query, Lector expectedA, UpdLectorA expected)
        {
            var model = (Lector)BLLManager.VerificationsQ.UpdateActivationLector(query);
            Mock.Setup(mock => mock.UpdateAcrivationLector(model)).Returns(expectedA);
            var actual =  BLLManager.VerificationsA.UpdateActivationLector(expectedA);
            Assert.AreEqual(actual, expected);
        }

        
    }
}