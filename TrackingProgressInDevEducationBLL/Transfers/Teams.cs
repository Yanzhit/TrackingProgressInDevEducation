using TrackingProgressInDevEducationBLL.Models.Team;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class Teams : ATransfer
    {
        public Teams SetNewTeam()
        {
            Query = typeof(SetTeamQ);
            Base = typeof(SetNewTeams);
            Answer = typeof(SetTeamA);
            return this;
        }
    }
}