using System.Collections;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models.Comment;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Expecteds
{
    public class EComments
    {
        public static IEnumerable GetCommentsByStudent()
        {
            yield return new object[]
            {
                new GetCommentsByStudentQ(1,1,1),
                new List<Comment>()
                {
                new Comment()
                {
                 
                },
                 new Comment()
                {
                  
                }
                },
                new List<GetCommentsByStudentA>()
                {
                    new GetCommentsByStudentA(),
                    new GetCommentsByStudentA()
                }
            };
            yield return new object[]
            {
                new GetCommentsByStudentQ(1,1,1),
                new List<Comment>()
                {
                new Comment()
                {

                },
                 new Comment()
                {

                }
                },
                new List<GetCommentsByStudentA>()
                {
                    new GetCommentsByStudentA(),
                    new GetCommentsByStudentA()
                }
            };
        }
        public static IEnumerable SetCommentToTeam()
        {
            yield return new object[]
            {
                new SetCommentsToTeamQ(),
                new Comment
                {

                },
                new SetCommentsToTeamA()
            };
            yield return new object[]
            {
                new SetCommentsToTeamQ(),
                new Comment
                {

                },
                new SetCommentsToTeamA()
            };
        }
        public static IEnumerable SetNewCommentToStudent()
        {
            yield return new object[]
            {
                new SetCommentsQ(),
                new Comment
                {
                 
                },
                new SetCommentsA()
            };
            yield return new object[]
            {
                new SetCommentsQ(),
                new Comment
                {
                 
                },
                new SetCommentsA()
            };
        }
    }
}