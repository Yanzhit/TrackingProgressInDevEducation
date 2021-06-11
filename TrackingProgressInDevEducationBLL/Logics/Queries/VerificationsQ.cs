using TrackingProgressInDevEducationBLL.Models.Verification;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class VerificationsQ : AQuery
    {
        public AbstractModel UpdateActivationLector(UpdLectorQ model)
        {
            WriteTypes(new Verifications().UpdateActivationLector());
            return GetModelBaseSingle(model);
        }
    }
}