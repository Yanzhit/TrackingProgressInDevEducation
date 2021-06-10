using TrackingProgressInDevEducationBLL.Models.MainPage;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;


namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class MainPagesQ : AQuery
    {
        public AbstractModel GetGroupsByLectorQ(GetGroupsByLectorQ model)
        {
            WriteTypes(new MainPage().GetGroupsByLectorJ());
            return (AbstractModel)GetModelBaseSingle(model);
        }

        public AbstractModel GetAllTeamsByLectorJ(GetAllTeamsByLectorJQ model)
        {
            WriteTypes(new MainPage().GetAllTeamsByLectorJ());
            return (AbstractModel)GetModelBaseSingle(model);
        }
    }
}
