using TrackingProgressInDevEducationBLL.Models.Team;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class CreateTeams : ATransfer
    {
        public CreateTeams SetNewTeam()
        {
            Query = typeof(SetTeamQ);
            Base = typeof(SetNewTeams);
            Answer = typeof(SetTeamA);
            return this;
        }
    }
}