using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.GroupInfo;
using TrackingProgressInDevEducationBLL.Models.GroupJournal;
using TrackingProgressInDevEducationBLL.Models.MainPage;
using TrackingProgressInDevEducationBLL.Models.Students;
using TrackingProgressInDevEducationBLL.Tests.Expecteds;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Tests.Tests
{
    public class TJoins : AbstractTest
    {
        public Mock<ILectors> Mock;

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<ILectors>();
        }

        [TestCaseSource(typeof(EJoins), nameof(EJoins.SetNewGroup))]
        public void SetNewGroup(SetGroupQ query, SetNewGroupJ expectedA, SetGroupA expected)
        {
            var model = (SetNewGroupJ)BLLManager.GroupsQ.SetNewGroup(query);
            Mock.Setup(mock => mock.SetNewGroup(model)).Returns(expectedA);
            var actual = BLLManager.GroupsA.SetNewGroup(expectedA);
            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(EJoins), nameof(EJoins.GetGroupByIdJ))]
        public void GetGroupByIdJA(GetGroupByIdJQ query, GetGroupByIdJ expectedA, GetGroupByIdJA expected)
        {
            var model = (GetGroupByIdJ)BLLManager.GroupInfosQ.GetGroupByIdJ(query);
            Mock.Setup(mock => mock.GetGroupByIdJ(model)).Returns(expectedA);
            var actual = BLLManager.GroupInfosA.GetGroupByIdJA(expectedA);
            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(EJoins), nameof(EJoins.GetGroupsByLectorJ))]
        public void GetGroupsByLectorJ(GetGroupsByLectorQ query, List<GetGroupByIdJ> expectedA, List<GetGroupsByLectorA> expected)
        {
            var model = (GetGroupByLectorJ)BLLManager.MainPagesQ.GetGroupsByLectorJ(query);
            Mock.Setup(mock => mock.GetGroupsByLectorJ(model)).Returns(expectedA);
            var actual = (List<GetGroupsByLectorA>)BLLManager.MainPagesA.GetGroupsByLectorJ(expectedA);
            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(EJoins), nameof(EJoins.GetAllStudentsByGroup))]
        public void GetAllStudentsByGroup(GetAllStudentsByGroupQ query, List<GetAllStudentsByGroup> expectedA, List<GetAllStudentsByGroupA> expected)
        {
            var model = (GetAllStudentsByGroup)BLLManager.GroupInfosQ.GetAllStudentsByGroup(query);
            Mock.Setup(mock => mock.GetAllStudentsByGroup(model)).Returns(expectedA);
            var actual = (List<GetAllStudentsByGroupA>)BLLManager.GroupInfosA.GetAllStudentsByGroupA(expectedA);
            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(EJoins), nameof(EJoins.GetAllCoursesByGroup))]
        public void GetAllCoursesByGroup(GetAllCoursesByGroupQ query, List<GetAllCoursesByGroup> expectedA, List<GetAllCoursesByGroupA> expected)
        {
            var model = (GetAllCoursesByGroup)BLLManager.GroupInfosQ.GetAllCoursesByGroup(query);
            Mock.Setup(mock => mock.GetAllCoursesByGroup(model)).Returns(expectedA);
            var actual = (List<GetAllCoursesByGroupA>)BLLManager.GroupInfosA.GetAllCoursesByGroupA(expectedA);
            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(EJoins), nameof(EJoins.GetAllTeamsByLectorJ))]
        public void GetAllTeamsByLectorJ(GetAllTeamsByLectorJQ query, List<GetAllTeamsByLectorJ> expectedA, List<GetAllTeamsByLectorJA> expected)
        {
            var model = (GetAllTeamsByLectorJ)BLLManager.MainPagesQ.GetAllTeamsByLectorJ(query);
            Mock.Setup(mock => mock.GetAllTeamsByLectorJ(model)).Returns(expectedA);
            var actual = (List<GetAllTeamsByLectorJA>)BLLManager.MainPagesA.GetAllTeamsByLectorJ(expectedA);
            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(EJoins), nameof(EJoins.GetAllStudents))]
        public void GetAllStudents(EmptyQ query, List<GetAllStudentsJ> expectedA, List<GetAllStudentsA> expected)
        {
            var model = (GetAllStudentsJ)BLLManager.StudentsSQ.GetAllStudents(query);
            Mock.Setup(mock => mock.GetAllStudents(model)).Returns(expectedA);
            var actual = (List<GetAllStudentsA>)BLLManager.StudentsSA.GetAllStudents(expectedA);
            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(EJoins), nameof(EJoins.GetVisitsByStudentJ))]
        public void GetVisitsByStudentJ(GetVisitsByStudentJQ query, List<GetVisitsByStudentJ> expectedA, List<GetAllStudentsA> expected)
        {
            var model = (GetVisitsByStudentJ)BLLManager.GroupJournalsQ.GetVisitsByStudentJ(query);
            Mock.Setup(mock => mock.GetVisitsByStudentJ(model)).Returns(expectedA);
            var actual = (List<GetVisitsByStudentJA>)BLLManager.GroupJournalsA.GetVisitsByStudentJ(expectedA);
            Assert.AreEqual(actual, expected);
        }
    }
}