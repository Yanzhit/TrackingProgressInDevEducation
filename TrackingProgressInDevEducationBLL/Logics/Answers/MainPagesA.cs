using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationBLL.Models.MainPage;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class MainPagesA : AAnswer
    {
        public IEnumerable<GetGroupsByLectorA> GetGroupsByLectorA(IEnumerable<AbstractModel> model)
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
