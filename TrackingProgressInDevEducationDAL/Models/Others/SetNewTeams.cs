using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Models.Others
{
    public class SetNewTeams : Team
    {
        public int? TeamId { get; set; }
        public int LectorId { get; set; }

        public SetNewTeams()
        {
        }

        public SetNewTeams(SetNewTeams model) : base(model)
        {
            TeamId = model.TeamId;
            LectorId = model.LectorId;
        }
    }
}
