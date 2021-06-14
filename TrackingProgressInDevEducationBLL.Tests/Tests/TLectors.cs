using Moq;
using NUnit.Framework;
using TrackingProgressInDevEducationBLL.Models.SignIn;
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

        //public SetLectorA SetNewLector(SetLectorQ setLectorQ)
        //{
        //    var model = (Lector)_bllManager.RegistrationsQ.SetNewLector(setLectorQ);
        //    Lector modelReturned = _dalManager.Lectors.SetNewLector(model);
        //    return _bllManager.RegistrationsA.SetNewLector(modelReturned);
        //}

        //public UpdLectorA UpdateAcrivationLector(UpdLectorQ updLectorQ)
        //{
        //    var model = (Lector)_bllManager.VerificationsQ.UpdateActivationLector(updLectorQ);
        //    Lector modelReturned = _dalManager.Lectors.UpdateAcrivationLector(model);
        //    return _bllManager.VerificationsA.UpdateActivationLector(modelReturned);
        //}

        //public List<SetCoursesA> GetAllCurses(SetCoursesQ setCoursesQ)
        //{
        //    _bllManager.CoursesQ.GetAllCourses(setCoursesQ);
        //    IEnumerable<Course> modelReturned = _dalManager.Courses.GetAllCourses();
        //    return (List<SetCoursesA>)_bllManager.CoursesA.GetSetCourses(modelReturned);
        //}
    }
}