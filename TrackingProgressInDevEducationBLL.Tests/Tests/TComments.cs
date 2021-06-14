using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models.Comment;
using TrackingProgressInDevEducationBLL.Tests.Expecteds;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Tests
{
    public class TComments : AbstractTest
    {
        public Mock<IComments> Mock;

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<IComments>();
        }

        [TestCaseSource(typeof(EComments), nameof(EComments.GetCommentsByStudent))]
        public void GetCommentsByStudent(GetCommentsByStudentQ query, List<Comment> expectedA, IEnumerable<GetCommentsByStudentA> expected)
        {
            var model = (Comment)BLLManager.CommentsQ.GetCommentsByStudent(query);
            Mock.Setup(mock => mock.GetCommentsByStudent(model)).Returns(expectedA);
            var actual = (List<GetCommentsByStudentA>)BLLManager.CommentsA.GetCommentsByStudent(expectedA);
            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(EComments), nameof(EComments.SetCommentToTeam))]
        public void SetCommentToTeam(SetCommentsToTeamQ query, Comment expectedA, SetCommentsToTeamA expected)
        {
            var model = (Comment)BLLManager.CommentsQ.SetCommentToTeam(query);
            Mock.Setup(mock => mock.SetCommentToTeam(model)).Returns(expectedA);
            var actual = BLLManager.CommentsA.SetCommentToTeam(expectedA);
            Assert.AreEqual(actual, expected);
        }


        [TestCaseSource(typeof(EComments), nameof(EComments.SetNewCommentToStudent))]
        public void SetNewCommentToStudent(SetCommentsQ query, Comment expectedA, SetCommentsA expected)
        {
            var model = (Comment)BLLManager.CommentsQ.SetNewCommentToStudent(query);
            Mock.Setup(mock => mock.SetNewCommentToStudent(model)).Returns(expectedA);
            var actual = BLLManager.CommentsA.SetNewCommentToStudent(expectedA);
            Assert.AreEqual(actual, expected);
        }
    }
}