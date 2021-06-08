using TrackingProgressInDevEducationBLL.Models.Verification;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class VerificationsA : AAnswer
    {
        public UpdLectorA UpdateActivationLector(AbstractModel model)
        {
            WriteTypes(new Verifications().UpdateActivationLector());
            return (UpdLectorA)GetModelBaseSingle(model);
        }
    }
}