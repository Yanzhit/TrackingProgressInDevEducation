using TrackingProgressInDevEducationBLL.Models.Team;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class TeamsQ : AQuery
    {
        public AbstractModel SetNewTeam(SetTeamQ model)
        {
            WriteTypes(new Teams().SetNewTeam());
            return GetModelBaseSingle(model);
        }
    }
}