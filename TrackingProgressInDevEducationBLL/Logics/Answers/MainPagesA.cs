using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models.MainPage;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;


namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class MainPagesA : AAnswer
    {
        public IEnumerable<GetGroupsByLectorA> GetGroupsByLectorJ(IEnumerable<AbstractModel> model)
        {
            WriteTypes(new MainPage().GetGroupsByLectorJ());
            return (IEnumerable<GetGroupsByLectorA>)GetModelBaseSeveral(model);
        }

        public IEnumerable<GetAllTeamsByLectorJA> GetAllTeamsByLectorJ(IEnumerable<AbstractModel> model)
        {
            WriteTypes(new MainPage().GetAllTeamsByLectorJ());
            return (IEnumerable<GetAllTeamsByLectorJA>)GetModelBaseSeveral(model);
        }
    }
}