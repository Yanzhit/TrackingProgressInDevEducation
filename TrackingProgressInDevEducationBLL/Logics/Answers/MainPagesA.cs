using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationBLL.Models.MainPage;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class MainPagesA : AAnswer
    {
        public IEnumerable<GetGroupsByLectorA> GetGroupsByLectorA(IEnumerable<AbstractModel> model)
        {
            WriteTypes(new MainPage().GetGroupByLectorJ());
            return (IEnumerable<GetGroupsByLectorA>)GetModelBaseSeveral(model);
        }
    }
}
