using TrackingProgressInDevEducationBLL.Models.Team;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class TeamsA : AAnswer
    {
        public SetTeamA SetNewTeam(AbstractModel model)
        {
            WriteTypes(new Teams().SetNewTeam());
            return (SetTeamA)GetModelBaseSingle(model);
        }
    }
}