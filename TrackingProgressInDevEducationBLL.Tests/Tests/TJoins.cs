using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.GroupInfo;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Tests.Expecteds;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
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

        [TestCaseSource(typeof(EJoins), nameof(EJoins.GetCities))]
        public void SetNewGroup(SetGroupQ query, SetNewGroupJ expectedA, SetGroupA expected)
        {
            var model = (SetNewGroupJ)BLLManager.GroupsQ.SetNewGroup(query);
            Mock.Setup(mock => mock.SetNewGroup(model)).Returns(expectedA);
            var actual = BLLManager.GroupsA.SetNewGroup(expectedA);
            Assert.AreEqual(actual, expected);
        }

        //public GetGroupByIdJA GetGroupByIdJ(GetGroupByIdJQ getGroupByIdJQ)
        //{
        //    var model = (GetGroupByIdJ)_bllManager.GroupInfosQ.GetGroupByIdJ(getGroupByIdJQ);
        //    GetGroupByIdJ modelReturned = _dalManager.Joins.GetGroupByIdJ(model);
        //    return _bllManager.GroupInfosA.GetGroupByIdJA(modelReturned);
        //}

        //public List<GetGroupsByLectorA> GetGroupsByLector(GetGroupsByLectorQ getGroupsByLectorQ)
        //{
        //    var model = (GetGroupByLectorJ)_bllManager.MainPagesQ.GetGroupsByLectorJ(getGroupsByLectorQ);
        //    IEnumerable<GetGroupByLectorJ> modelReturned = _dalManager.Joins.GetGroupByLectorJ(model);
        //    return (List<GetGroupsByLectorA>)_bllManager.MainPagesA.GetGroupsByLectorJ(modelReturned);
        //}

        //public List<GetAllStudentsByGroupA> GetAllStudentsByGroup(GetAllStudentsByGroupQ query)
        //{
        //    var model = (GetAllStudentsByGroup)_bllManager.GroupInfosQ.GetAllStudentsByGroup(query);
        //    IEnumerable<GetAllStudentsByGroup> modelReturned = _dalManager.Joins.GetAllStudentsByGroup(model);
        //    return (List<GetAllStudentsByGroupA>)_bllManager.GroupInfosA.GetAllStudentsByGroupA(modelReturned);
        //}

        //public List<GetAllCoursesByGroupA> GetAllCoursesByGroup(GetAllCoursesByGroupQ getAllCoursesByGroupQ)
        //{
        //    var model = (GetAllCoursesByGroup)_bllManager.GroupInfosQ.GetAllCoursesByGroup(getAllCoursesByGroupQ);
        //    IEnumerable<GetAllCoursesByGroup> modelReturned = _dalManager.Joins.GetAllCoursesByGroup(model);
        //    return (List<GetAllCoursesByGroupA>)_bllManager.GroupInfosA.GetAllCoursesByGroupA(modelReturned);
        //}

        //public List<GetAllTeamsByLectorJA> GetAllTeamsByLectorJ(GetAllTeamsByLectorJQ getTeamssByLectorQ)
        //{
        //    var model = (GetAllTeamsByLectorJ)_bllManager.MainPagesQ.GetAllTeamsByLectorJ(getTeamssByLectorQ);
        //    IEnumerable<GetAllTeamsByLectorJ> modelReturned = _dalManager.Joins.GetAllTeamsByLectorJ(model);
        //    return (List<GetAllTeamsByLectorJA>)_bllManager.MainPagesA.GetAllTeamsByLectorJ(modelReturned);
        //}

        //public List<GetAllStudentsA> GetAllStudents(EmptyQ emptyQ)
        //{
        //    var model = (GetAllStudentsJ)_bllManager.StudentsSQ.GetAllStudents(emptyQ);
        //    IEnumerable<GetAllStudentsJ> modelReturned = _dalManager.Joins.GetAllStudents();
        //    return (List<GetAllStudentsA>)_bllManager.StudentsSA.GetAllStudents(modelReturned);
        //}

        //public List<GetVisitsByStudentJA> GetVisitsByStudentJ(GetVisitsByStudentJQ query)
        //{
        //    var model = (GetVisitsByStudentJ)_bllManager.GroupJournalsQ.GetVisitsByStudentJ(query);
        //    IEnumerable<GetVisitsByStudentJ> modelReturned = _dalManager.Joins.GetVisitsByStudentJ(model);
        //    return (List<GetVisitsByStudentJA>)_bllManager.GroupJournalsA.GetVisitsByStudentJ(modelReturned);
        //}
    }
}