using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationBLL.Models.MainPage;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class MainPagesQ : AQuery
    {
        public AbstractModel GetGroupsByLectorQ(GetGroupsByLectorQ model)
        {
            WriteTypes(new MainPage().GetGroupsByLectorJ());
            return GetModelBaseSingle(model);
        }

        public AbstractModel GetAllTeamsByLectorJ(GetAllTeamsByLectorJQ model)
        {
            WriteTypes(new MainPage().GetAllTeamsByLectorJ());
            return GetModelBaseSingle(model);
        }
    }
}
