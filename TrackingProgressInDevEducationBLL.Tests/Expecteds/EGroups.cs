using System.Collections;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.Course;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Expecteds
{
    public class EGroups
    {
        public static IEnumerable SetNewCourse()
        {
            yield return new object[]
           {
                new EmptyQ(),
                new Group
                {
                    Id = 1,
                    Name = "sssss",
                },
                new GetGroupsA(1, "sssss")
           };
            yield return new object[]
            {
                new EmptyQ(),
                new Group
                {
                    Id = 2,
                    Name = "eeee",
                },
                new GetGroupsA(2, "eeee")
            };
        }
    }
}