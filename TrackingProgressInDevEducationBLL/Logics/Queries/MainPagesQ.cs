using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationBLL.Models.MainPage;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class MainPagesQ : AQuery
    {
        public AbstractModel GetGroupsByLectorQ(GetGroupsByLectorQ model)
        {
            WriteTypes(new MainPage().GetGroupByLectorJ());
            return (AbstractModel)GetModelBaseSingle(model);
        }
    }
}
