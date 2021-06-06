using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Queries
{
    public class QSignIns : AQuery
    {
        public AbstractModel GetLoginAndPassword(LectorQuery lectorQuery)
        {
            WriteTypes(new SignInLector());
            return GetModelBaseSingle(lectorQuery);
        }
    }
}