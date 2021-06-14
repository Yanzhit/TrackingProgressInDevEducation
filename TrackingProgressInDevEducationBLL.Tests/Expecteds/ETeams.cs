using System.Collections;
using TrackingProgressInDevEducationBLL.Models.Team;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Tests.Expecteds
{
    public class ETeams
    {
        public static IEnumerable SetNewTeam()
        {
            yield return new object[]
            {
                new SetTeamQ(),
                new SetNewTeams
                {
                    Name = "qqq",
                    From = "222",
                    To = "2"
                },
                new SetTeamA("qqq", "222", "2")
            };
            yield return new object[]
            {
                new SetTeamQ(),
                new SetNewTeams
                {
                    Name = "www",
                    From = "232",
                    To = "1"
                },
                new SetTeamA("www", "232", "1")
            };
        }
    }
}